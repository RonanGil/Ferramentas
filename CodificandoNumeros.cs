using System;

namespace CodificandoNumeros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string NaoCodificado = "33592510000154"; //CNPJ Empresa Vale do Rio Doce
            
            EncoderCode EncoderCode = new EncoderCode(NaoCodificado);
            
            Console.WriteLine("Código Original  : " + NaoCodificado);
            Console.WriteLine("Código Codificado: " + EncoderCode.GetSetCodEncoder);
        }
    }
    
    public class EncoderCode
    {
        private string _CodEncoder;
        private SByte  _TamCopy = 0;
        private SByte  _ParCod  = 0;
        private SByte  _ImpCod  = 0;
                
        public  string GetSetCodEncoder { get { return this._CodEncoder;  } set { this._CodEncoder = value; } }
        private SByte  GetSetTamCopy    { get { return this._TamCopy;     } set { this._TamCopy    = value; } }
        private SByte  GetSetParCod     { get { return this._ParCod;      } set { this._ParCod     = value; } }
        private SByte  GetSetImpCod     { get { return this._ImpCod;      } set { this._ImpCod     = value; } }
        
        public EncoderCode(string codDigitado)
        {
            StartEncode(codDigitado);
        }
        
        private void StartEncode(string codDigitado)
        {
            GetSetParCod = (SByte)(codDigitado.Length - (codDigitado.Length / 2F));
	    GetSetImpCod = (SByte)(codDigitado.Length % 2);
			
            while(GetSetParCod !=0)
            {
                Codificando(codDigitado.Substring(GetSetTamCopy, 2));
                GetSetParCod  -= 1;
                GetSetTamCopy += 2;
            }
            
            if(GetSetImpCod  > 0)
		Codificando(codDigitado.Substring((codDigitado.Length - 1), 1));
        }
        
        private void Codificando(string partCodDigitado)
        {
            switch(partCodDigitado)
            {
                case "00": _CodEncoder = _CodEncoder + "a"; break;
		case "01": _CodEncoder = _CodEncoder + "â"; break;
		case "02": _CodEncoder = _CodEncoder + "ã"; break;
		case "03": _CodEncoder = _CodEncoder + "á"; break;
		case "04": _CodEncoder = _CodEncoder + "à"; break;
		case "05": _CodEncoder = _CodEncoder + "e"; break;
		case "06": _CodEncoder = _CodEncoder + "ê"; break;
		case "07": _CodEncoder = _CodEncoder + "é"; break;
		case "08": _CodEncoder = _CodEncoder + "è"; break;
		case "09": _CodEncoder = _CodEncoder + "f"; break;
					
		case "10": _CodEncoder = _CodEncoder + "g"; break;
		case "11": _CodEncoder = _CodEncoder + "h"; break;
		case "12": _CodEncoder = _CodEncoder + "i"; break;
		case "13": _CodEncoder = _CodEncoder + "î"; break;
		case "14": _CodEncoder = _CodEncoder + "í"; break;
		case "15": _CodEncoder = _CodEncoder + "ì"; break;
		case "16": _CodEncoder = _CodEncoder + "j"; break;
		case "17": _CodEncoder = _CodEncoder + "k"; break;
		case "18": _CodEncoder = _CodEncoder + "l"; break;
		case "19": _CodEncoder = _CodEncoder + "m"; break;
					
		case "20": _CodEncoder = _CodEncoder + "n"; break;
		case "21": _CodEncoder = _CodEncoder + "o"; break;
		case "22": _CodEncoder = _CodEncoder + "ô"; break;
		case "23": _CodEncoder = _CodEncoder + "õ"; break;
		case "24": _CodEncoder = _CodEncoder + "ó"; break;
		case "25": _CodEncoder = _CodEncoder + "ò"; break;
		case "26": _CodEncoder = _CodEncoder + "p"; break;
		case "27": _CodEncoder = _CodEncoder + "q"; break;
		case "28": _CodEncoder = _CodEncoder + "r"; break;
		case "29": _CodEncoder = _CodEncoder + "s"; break;
					
		case "30": _CodEncoder = _CodEncoder + "t"; break;
		case "31": _CodEncoder = _CodEncoder + "u"; break;
		case "32": _CodEncoder = _CodEncoder + "û"; break;
		case "33": _CodEncoder = _CodEncoder + "ú"; break;
		case "34": _CodEncoder = _CodEncoder + "ù"; break;
		case "35": _CodEncoder = _CodEncoder + "v"; break;
		case "36": _CodEncoder = _CodEncoder + "x"; break;
		case "37": _CodEncoder = _CodEncoder + "y"; break;
		case "38": _CodEncoder = _CodEncoder + "ý"; break;
		case "39": _CodEncoder = _CodEncoder + "z"; break;
					
		case "40": _CodEncoder = _CodEncoder + "\""; break;
		case "41": _CodEncoder = _CodEncoder + "'"; break;
		case "42": _CodEncoder = _CodEncoder + "!"; break;
		case "43": _CodEncoder = _CodEncoder + "@"; break;
		case "44": _CodEncoder = _CodEncoder + "#"; break;
		case "45": _CodEncoder = _CodEncoder + "$"; break;
		case "46": _CodEncoder = _CodEncoder + "%"; break;
		case "47": _CodEncoder = _CodEncoder + "¨"; break;
		case "48": _CodEncoder = _CodEncoder + "¬"; break;
		case "49": _CodEncoder = _CodEncoder + "&"; break;
					
		case "50": _CodEncoder = _CodEncoder + "*"; break;
		case "51": _CodEncoder = _CodEncoder + "("; break;
		case "52": _CodEncoder = _CodEncoder + ")"; break;
		case "53": _CodEncoder = _CodEncoder + "_"; break;
		case "54": _CodEncoder = _CodEncoder + "╚"; break;
		case "55": _CodEncoder = _CodEncoder + "+"; break;
		case "56": _CodEncoder = _CodEncoder + "="; break;
		case "57": _CodEncoder = _CodEncoder + "§"; break;
		case "58": _CodEncoder = _CodEncoder + "¹"; break;
		case "59": _CodEncoder = _CodEncoder + "²"; break;
					
		case "60": _CodEncoder = _CodEncoder + "³"; break;
		case "61": _CodEncoder = _CodEncoder + "£"; break;
		case "62": _CodEncoder = _CodEncoder + "¢"; break;
		case "63": _CodEncoder = _CodEncoder + "|"; break;
		case "64": _CodEncoder = _CodEncoder + "\\"; break;
		case "65": _CodEncoder = _CodEncoder + "/"; break;
		case "66": _CodEncoder = _CodEncoder + "<"; break;
		case "67": _CodEncoder = _CodEncoder + ","; break;
		case "68": _CodEncoder = _CodEncoder + ">"; break;
		case "69": _CodEncoder = _CodEncoder + "╔"; break;
				
		case "70": _CodEncoder = _CodEncoder + ":"; break;
		case "71": _CodEncoder = _CodEncoder + ";"; break;
		case "72": _CodEncoder = _CodEncoder + "ç"; break;
		case "73": _CodEncoder = _CodEncoder + "^"; break;
		case "74": _CodEncoder = _CodEncoder + "~"; break;
		case "75": _CodEncoder = _CodEncoder + "]"; break;
		case "76": _CodEncoder = _CodEncoder + "}"; break;
		case "77": _CodEncoder = _CodEncoder + "["; break;
		case "78": _CodEncoder = _CodEncoder + "{"; break;
		case "79": _CodEncoder = _CodEncoder + "°"; break;
					
		case "80": _CodEncoder = _CodEncoder + "ª"; break;
		case "81": _CodEncoder = _CodEncoder + "º"; break;
		case "82": _CodEncoder = _CodEncoder + "´"; break;
		case "83": _CodEncoder = _CodEncoder + "`"; break;
		case "84": _CodEncoder = _CodEncoder + "♂"; break;
		case "85": _CodEncoder = _CodEncoder + "♀"; break;
		case "86": _CodEncoder = _CodEncoder + "♪"; break;
		case "87": _CodEncoder = _CodEncoder + "♫"; break;
		case "88": _CodEncoder = _CodEncoder + "☼"; break;
		case "89": _CodEncoder = _CodEncoder + "►"; break;
					
		case "90": _CodEncoder = _CodEncoder + "◄"; break;
		case "91": _CodEncoder = _CodEncoder + "↕"; break;
		case "92": _CodEncoder = _CodEncoder + "‼"; break;
		case "93": _CodEncoder = _CodEncoder + "¶"; break;
		case "94": _CodEncoder = _CodEncoder + "▬"; break;
		case "95": _CodEncoder = _CodEncoder + "↨"; break;
		case "96": _CodEncoder = _CodEncoder + "↑"; break;
		case "97": _CodEncoder = _CodEncoder + "↓"; break;
		case "98": _CodEncoder = _CodEncoder + "→"; break;
		case "99": _CodEncoder = _CodEncoder + "←"; break;
					
		case "0": _CodEncoder = _CodEncoder + "∟"; break;
		case "1": _CodEncoder = _CodEncoder + "↔"; break;
		case "2": _CodEncoder = _CodEncoder + "▲"; break;
		case "3": _CodEncoder = _CodEncoder + "▼"; break;
		case "4": _CodEncoder = _CodEncoder + "♥"; break;
		case "5": _CodEncoder = _CodEncoder + "♦"; break;
		case "6": _CodEncoder = _CodEncoder + "♣"; break;
		case "7": _CodEncoder = _CodEncoder + "♠"; break;
		case "8": _CodEncoder = _CodEncoder + "○"; break;
		case "9": _CodEncoder = _CodEncoder + "•"; break;
            }
        }
    } 
}
