//<auto-generated />

using System.Text;

namespace KFLibrary.Text
{
	public enum FontEnum
		{
			Unicode,
			VPS,
			VISCII,
			TCVN,
			VNI,
			VIQR
		}
	/// <summary>
	/// Summary description for ChuyenMa.
	/// </summary>
	public class ChuyenMa
	{
		

		private	static string strUnicodeVowels	= "áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐ";
		private	static string[] UnicodeVowels	= {
													  "á", "à", "ả", "ã", "ạ", "ă", "ắ", "ằ", "ẳ", "ẵ",
													  "ặ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "é", "è", "ẻ",
													  "ẽ", "ẹ", "ê", "ế", "ề", "ể", "ễ", "ệ", "í", "ì",
													  "ỉ", "ĩ", "ị", "ó", "ò", "ỏ", "õ", "ọ", "ô", "ố",
													  "ồ", "ổ", "ỗ", "ộ", "ơ", "ớ", "ờ", "ở", "ỡ", "ợ",
													  "ú", "ù", "ủ", "ũ", "ụ", "ư", "ứ", "ừ", "ử", "ữ",
													  "ự", "ý", "ỳ", "ỷ", "ỹ", "ỵ", "đ", "Á", "À", "Ả",
													  "Ã", "Ạ", "Ă", "Ắ", "Ằ", "Ẳ", "Ẵ", "Ặ", "Â", "Ấ",
													  "Ầ", "Ẩ", "Ẫ", "Ậ", "É", "È", "Ẻ", "Ẽ", "Ẹ", "Ê",
													  "Ế", "Ề", "Ể", "Ễ", "Ệ", "Í", "Ì", "Ỉ", "Ĩ", "Ị",
													  "Ó", "Ò", "Ỏ", "Õ", "Ọ", "Ô", "Ố", "Ồ", "Ổ", "Ỗ",
													  "Ộ", "Ơ", "Ớ", "Ờ", "Ở", "Ỡ", "Ợ", "Ú", "Ù", "Ủ",
													  "Ũ", "Ụ", "Ư", "Ứ", "Ừ", "Ử", "Ữ", "Ự", "Ý", "Ỳ",
													  "Ỷ", "Ỹ", "Ỵ", "Đ"
												  };
		// VPS
		private	static string VPSVowels			= "áàäãåæ¡¢£¤¥âÃÀÄÅÆéèÈëËê‰Š‹ÍŒíìÌïÎóòÕõ†ôÓÒ°‡¶Ö§©ª«®úùûÛøÜÙØº»¿šÿ›ÏœÇÁÁÁÁÁˆˆˆˆðˆÂƒ„…ÂÂÉ×ÞþÉÊÊ“”•Ê´µ·¸´¹¼½¾¹Ô–—˜™–÷÷÷Ÿ¦÷Ú¨Ñ¬ÚÐ­¯±ÐÐÝ²ý³Ýñ";
		private	static string VISCIIVowels		= "áàäãÕå¡¢ÆÇ£â¤¥¦ç§éèë¨©êª«¬­®íìïî¸óòöõ÷ô¯°±²µ½¾¶·ÞþúùüûøßÑ×ØæñýÏÖÛÜðÁÀÄÃÁÅ‚AAƒÂ„…†‡ÉÈËˆ‰ÊŠ‹ŒÊÍÌ›Î˜ÓÒ???Ô‘’“´•–—³”ÚÙœÚ¿º»¼ÿ¹ÝŸ???Ð";
		private	static string TCVNVowels		= "¸µ¶·¹¨¾»¼½Æ©ÊÇÈÉËÐÌÎÏÑªÕÒÓÔÖÝ×ØÜÞãßáâä«èåæçé¬íêëìîóïñòô­øõö÷ùýúûüþ®¸µ¶·¹¡¡¡¡¡¡¢¢¢¢¢¢ÐÌÎÏÑ££££££Ý×ØÜÞãßáâä¤¤¤¤¤¤¥¥¥¥¥¥óïñòô¦¦¦¦¦¦ýúûüþ§";

		
		private static string[] VNIVowels		= {
													  "aù", "aø", "aû", "aõ", "aï", "aê", "aé", "aè", "aú", "aü",
													  "aë", "aâ", "aá", "aà", "aå", "aã", "aä", "eù", "eø", "eû",
													  "eõ", "eï", "eâ", "eá", "eà", "eå", "eã", "eä", "í", "ì",
													  "æ", "ó", "ò", "où", "oø", "oû", "oõ", "oï", "oâ", "oá",
													  "oà", "oå", "oã", "oä", "ô", "ôù", "ôø", "ôû", "ôõ", "ôï",
													  "uù", "uø", "uû", "uõ", "uï", "ö", "öù", "öø", "öû", "öõ",
													  "öï", "yù", "yø", "yû", "yõ", "î", "ñ", "AÙ", "AØ", "AÛ",
													  "AÕ", "AÏ", "AÊ", "AÉ", "AÈ", "AÚ", "AÜ", "AË", "AÂ", "AÁ",
													  "AÀ", "AÅ", "AÃ", "AÄ", "EÙ", "EØ", "EÛ", "EÕ", "EÏ", "EÂ",
													  "EÁ", "EÀ", "EÅ", "EÃ", "EÄ", "Í", "Ì", "Æ", "Ó", "Ò", "OÙ",
													  "OØ", "OÛ", "OÕ", "OÏ", "OÂ", "OÁ", "OÀ", "OÅ", "OÃ", "OÄ",
													  "Ô", "ÔÙ", "ÔØ", "ÔÛ", "ÔÕ", "ÔÏ", "UÙ", "UØ", "UÛ", "UÕ",
													  "UÏ", "Ö", "ÖÙ", "ÖØ", "ÖÛ", "ÖÕ", "ÖÏ", "YÙ", "YØ", "YÛ",
													  "YÕ", "Î", "Ñ"
												  };

		private static string[] repairVNIVowels	= {
													  "auø", "aø", "aû", "aoõ", "aï", "aeâ", "aeuø", "aeø", "auuø", "aü",
													  "aë", "aâ", "aá", "aà", "aå", "aã", "aä", "euø", "eø", "eû",
													  "eoõ", "eï", "eâ", "eá", "eà", "eå", "eã", "eä", "í", "ì",
													  "æ", "ouø", "oø", "ouø", "oø", "oû", "oõ", "oï", "oâ", "oá",
													  "oà", "oå", "oã", "oä", "ô", "ôuø", "ôø", "ôû", "ôõ", "ôï",
													  "uuø", "uø", "uû", "uõ", "uï", "ö", "öù", "öø", "öû", "öõ",
													  "öï", "yù", "yø", "yû", "yõ", "î", "ñ", "AUØ", "AØ", "AÛ",
													  "AOÕ", "AÏ", "AEÂ", "AEUØ", "AEØ", "AUUØ", "AÜ", "AË", "AÂ", "AÁ",
													  "AÀ", "AÅ", "AÃ", "AÄ", "EUØ", "EØ", "EÛ", "EOÕ", "EÏ", "EÂ",
													  "EÁ", "EÀ", "EÅ", "EÃ", "EÄ", "Í", "Ì", "Æ", "OUØ", "OØ",
													  "OUØ", "OØ", "OÛ", "OÕ", "OÏ", "OÂ", "OÁ", "OÀ", "OÅ", "OÃ",
													  "OÄ", "Ô", "ÔUØ", "ÔØ", "ÔÛ", "ÔÕ", "ÔÏ", "UUØ", "UØ", "UÛ",
													  "UÕ", "UÏ", "Ö", "ÖÙ", "ÖØ", "ÖÛ", "ÖÕ", "ÖÏ", "YÙ", "YØ",
													  "YÛ", "YÕ", "Î", "Ñ"
												  };
		private static string[] VIQRVowels		= {
													  "a'", "a`", "a?", "a~", "a.", "a(", "a('", "a(`", "a(?", "a(~",
													  "a(.", "a^", "a^'", "a^`", "a^?", "a^~", "a^.", "e'", "e`", "e?",
													  "e~", "e.", "e^", "e^'", "e^`", "e^?", "e^~", "e^.", "i'", "i`",
													  "i?", "i~", "i.", "o'", "o`", "o?", "o~", "o.", "o^", "o^'",
													  "o^`", "o^?", "o^~", "o^.", "o+", "o+'", "o+`", "o+?", "o+~",
													  "o+.", "u'", "u`", "u?", "u~", "u.", "u+", "u+'", "u+`", "u+?",
													  "u+~", "u+.", "y'", "y`", "y?", "y~", "y.", "dd", "A'", "A`", "A?",
													  "A~", "A.", "A(", "A('", "A(`", "A(?", "A(~", "A(.", "A^", "A^'",
													  "A^`", "A^?", "A^~", "A^.", "E'", "E`", "E?", "E~", "E.", "E^",
													  "E^'", "E^`", "E^?", "E^~", "E^.", "I'", "I`", "I?", "I~", "I.",
													  "O'", "O`", "O?", "O~", "O.", "O^", "O^'", "O^`", "O^?", "O^~",
													  "O^.", "O+", "O+'", "O+`", "O+?", "O+~", "O+.", "U'", "U`", "U?",
													  "U~", "U.", "U+", "U+'", "U+`", "U+?", "U+~", "U+.", "Y'", "Y`",
													  "Y?", "Y~", "Y.", "DD"
												  };

		private static string[] VNIVowelMap		= {
													  "aù 001", "aø 002", "aû 003", "aõ 004", "aï 005", "aê 006", "aé 007", "aè 008", "aú 009", "aü 010",
													  "aë 011", "aâ 012", "aá 013", "aà 014", "aå 015", "aã 016", "aä 017", "eù 018", "eø 019", "eû 020",
													  "eõ 021", "eï 022", "eâ 023", "eá 024", "eà 025", "eå 026", "eã 027", "eä 028", "où 034", "oø 035",
													  "oû 036", "oõ 037", "oï 038", "oâ 039", "oá 040", "oà 041", "oå 042", "oã 043", "oä 044", "ôù 046",
													  "ôø 047", "ôû 048", "ôõ 049", "ôï 050", "uù 051", "uø 052", "uû 053", "uõ 054", "uï 055", "öù 057",
													  "öø 058", "öû 059", "öõ 060", "öï 061", "yù 062", "yø 063", "yû 064", "yõ 065", "AÙ 068", "AØ 069",
													  "AÛ 070", "AÕ 071", "AÏ 072", "AÊ 073", "AÉ 074", "AÈ 075", "AÚ 076", "AÜ 077", "AË 078", "AÂ 079",
													  "AÁ 080", "AÀ 081", "AÅ 082", "AÃ 083", "AÄ 084", "EÙ 085", "EØ 086", "EÛ 087", "EÕ 088", "EÏ 089",
													  "EÂ 090", "EÁ 091", "EÀ 092", "EÅ 093", "EÃ 094", "EÄ 095", "OÙ 101", "OØ 102", "OÛ 103", "OÕ 104",
													  "OÏ 105", "OÂ 106", "OÁ 107", "OÀ 108", "OÅ 109", "OÃ 110", "OÄ 111", "ÔÙ 113", "ÔØ 114", "ÔÛ 115",
													  "ÔÕ 116", "ÔÏ 117", "UÙ 118", "UØ 119", "UÛ 120", "UÕ 121", "UÏ 122", "ÖÙ 124", "ÖØ 125", "ÖÛ 126",
													  "ÖÕ 127", "ÖÏ 128", "YÙ 129", "YØ 130", "YÛ 131", "YÕ 132", "í  029", "ì  030", "æ  031", "ó  032",
													  "ò  033", "ô  045", "ö  056", "î  066", "ñ  067", "Í  096", "Ì  097", "Æ  098", "Ó  099", "Ò  100",
													  "Ô  112", "Ö  123", "Î  133", "Ñ  134"
												  };
		private static string[] VIQRVowelMap	= {
													  "a' 001", "a` 002", "a? 003", "a~ 004", "a. 005", "a('007", "a(`008", "a(?009", "a(~010", "a(.011",
													  "a( 006", "a^'013", "a^`014", "a^?015", "a^~016", "a^.017", "a^ 012", "e' 018", "e` 019", "e? 020",
													  "e~ 021", "e. 022", "e^'024", "e^`025", "e^?026", "e^~027", "e^.028", "e^ 023", "i' 029", "i` 030",
													  "i? 031", "i~ 032", "i. 033", "o' 034", "o` 035", "o? 036", "o~ 037", "o. 038", "o^'040", "o^`041",
													  "o^?042", "o^~043", "o^.044", "o^ 039", "o+'046", "o+`047", "o+?048", "o+~049", "o+.050", "o+ 045",
													  "u' 051", "u` 052", "u? 053", "u~ 054", "u. 055", "u+'057", "u+`058", "u+?059", "u+~060", "u+.061",
													  "u+ 056", "y' 062", "y` 063", "y? 064", "y~ 065", "y. 066", "dd 067", "A' 068", "A` 069", "A? 070",
													  "A~ 071", "A. 072", "A('074", "A(`075", "A(?076", "A(~077", "A(.078", "A( 073", "A^'080", "A^`081",
													  "A^?082", "A^~083", "A^.084", "A^ 079", "E' 085", "E` 086", "E? 087", "E~ 088", "E. 089", "E^'091",
													  "E^`092", "E^?093", "E^~094", "E^.095", "E^ 090", "I' 096", "I` 097", "I? 098", "I~ 099", "I. 100",
													  "O' 101", "O` 102", "O? 103", "O~ 104", "O. 105", "O^'107", "O^`108", "O^?109", "O^~110", "O^.111",
													  "O^ 106", "O+'113", "O+`114", "O+?115", "O+~116", "O+.117", "O+ 112", "U' 118", "U` 119", "U? 120",
													  "U~ 121", "U. 122", "U+'124", "U+`125", "U+?126", "U+~127", "U+.128", "U+ 123", "Y' 129", "Y` 130",
													  "Y? 131", "Y~ 132", "Y. 133", "DD 134"
												  };

		/// <summary>
		/// Convert Unicode vowels to an encoding like VNI or VIQR where it might take more than one
		/// </summary>
		/// <param name="p_Text"></param>
		/// <param name="Vowel"></param>
		/// <returns></returns>
		private static string UnicodeToMultichar(string p_Text, string[] Vowel, bool isVNI)
		{
			//	characters to represent a vowel.
			char letter;
			string Text1 = "", Text2 = "";
			int i, Pos;
			
			// Replace "ó", "ò", "Ó", "Ò"
			if(isVNI)
			{
				p_Text = p_Text.Replace("ó", "|o'|");
				p_Text = p_Text.Replace("ò", "|o`|");
				p_Text = p_Text.Replace("Ó", "|O'|");
				p_Text = p_Text.Replace("Ò", "|O`|");
			}

			StringBuilder strB = new StringBuilder(p_Text);
			
			for (i = 0; i < UnicodeVowels.Length; i++)
			{
				strB.Replace(UnicodeVowels[i], Vowel[i]);
			}
			
			string str = strB.ToString();
			if(isVNI)
			{
				for (i = 0; i < repairVNIVowels.Length; i++)
				{
					str = str.Replace(repairVNIVowels[i], Vowel[i]);
				}
				// Replace "ó", "ò", "Ó", "Ò"
				str = str.Replace("|o'|","où");
				str = str.Replace("|o`|","oø");
				str = str.Replace("|O'|","OÙ");
				str = str.Replace("|O`|","OØ");
			}
			return str;
			
			Text1 = p_Text;
			//	Iterate through every Unicode character, don't care if it take 1,2 or 3 characters internally
			for (i = 0; i< Text1.Length; i++)
			{
				//	get a Unicode character
				letter = Text1[i];
				//	if it's a Carriage return or a LineFeed then just copy across
			
				//	can we find it in the Unicode vowel list?
				Pos = strUnicodeVowels.IndexOfAny(new char[]{letter});
				if (Pos < 0)
					//	Not found - if not then just copy across as is
					Text2 = Text2 + letter;
				else
					//	Found - convert to the corresponding multi-character vowel of VNI or VIQR
					Text2 = Text2 + Vowel[Pos];
			}
			//	return the result
			return Text2;
		}

		/// <summary>
		/// Convert a multi-character vowel in VNI or VIQR to Unicode
		/// </summary>
		/// <param name="p_Text"></param>
		/// <param name="Vowel"></param>
		/// <returns></returns>
		private static string MulticharToUnicode(string p_Text, string[] Vowel)
		{
			string letter = "", Text1 = "", Text2 = "", Item = "", MapNum = "";
			int Pos, i, TLen;

			Text1 = p_Text;
			//	Replace every multi-character vowel in Text1 with a string like
			//	|067 that represents the 67th Unicode vowel
			//	Iterate through every multi-character vowel
			for (i = 0; i< Vowel.Length; i++)
			{
				// Get an item from the Vowel listbox
				Item = Vowel[i];	// like a^~016
				letter = Item.Substring(0,3).Trim(); //' isolate the multi-character vowel eg: a^~
				MapNum = "|" + Item.Substring(3); //' Prefix the | character to the digit string eg: &016

				Text1 = Text1.Replace(letter, MapNum); //' replace all occurences of the vowel
			} 
			// Now map the position strings like &016, &114 to 16th and 114th Unicode vowels
			i = 0;
			TLen = Text1.Length;

			while (i < TLen)
			{
				// get a character
				letter = Text1.Substring(i, 1);
				//' if it's a Carriage return or a LineFeed then just copy across
				if (letter != "|")
				{
					//	merely copy across everything else
					Text2 = Text2 + letter;
					i = i + 1;
				}
				else
				{
					// get here if encounter a "&", obtain the position of the Unicode vowel
					// Note that there'll be a bug if the text string contains genuine "|" character
					try
					{
						Pos = int.Parse(Text1.Substring(i + 1, 3));
					}
					catch
					{
						Pos = 0;
					}

					if (Pos == 0)
					{
						Text2 = Text2 + letter;
						i = i + 1;
					}
					else
					{
						//' get the Unicode vowel for output
						Text2 = Text2 + UnicodeVowels[Pos-1];
					
						i = i + 4;
					}
				}
			}
			//' Return the result
			return Text2;
		}

		/// <summary>
		/// Direct one-to-one character mapping from one encoding to another
		/// </summary>
		/// <param name="p_Text"></param>
		/// <param name="Vowel1"></param>
		/// <param name="Vowel2"></param>
		/// <returns></returns>
		private static string StringToString(string p_Text, string Vowel1, string Vowel2)
		{
			char letter;
			string Text1 = "", Text2 = "";

			int i, Pos;
			Text1 = p_Text;

			//	Iterate through each character of the from Text string
			for(i = 0;i<Text1.Length;i++)
			{
				letter = Text1[i];
				//	Find position of character in the vowel list
				Pos = Vowel1.IndexOfAny(new char[]{letter});

				if (Pos < 0)
					//	Not found - so do  not map
					Text2 = Text2 + letter;
				else
					//	Found - so pick the corresponding character in the other vowel list
					Text2 = Text2 + Vowel2[Pos];
			}
			return Text2;
		}

		public static string EncodingString(string p_Text, FontEnum fromEncoding, FontEnum toEncoding)
		{
			//	One encoding must be Unicode, but not both
			if (fromEncoding == FontEnum.Unicode)
			{
				if (toEncoding == FontEnum.Unicode)
				{
					//throw new Exception("Both encodings are Unicode");
					return p_Text;
				}
			}
			else if (toEncoding != FontEnum.Unicode)
			{
				//throw new Exception("One encoding must be Unicode");
				return p_Text;
			}
			if (fromEncoding == FontEnum.Unicode)
				//	get here if we're to convert FROM Unicode to another encoding
				switch (toEncoding)
				{
					case FontEnum.VPS:
						//	Convert the Text from Unicode to VPS, using one-to-one look-up
						return StringToString(p_Text, strUnicodeVowels, VPSVowels);
					case FontEnum.VISCII:
						//	Convert the Text from Unicode to VISCII, using one-to-one look-up
						return StringToString(p_Text, strUnicodeVowels, VISCIIVowels);
					case FontEnum.TCVN:
						// Convert the Text from Unicode to TCVN, using one-to-one look-up
						//'  Note that this might not be correct for TCVN Uppercase (chu HOA)
						//'     as each TCVN Uppercase takes 2 characters.
						//' If necessary, use the same conversion technique as for VNI and VIQR
						return StringToString(p_Text, strUnicodeVowels, TCVNVowels);

					case FontEnum.VNI:
						// Each VNI vowel might take 2 characters. Read VNI Vowels into a String Array
						//	Convert the Text from Unicode to VNI, using look-up one Unicode vowel corresponds
						//		to a VNI Vowel in a String Array
						return UnicodeToMultichar(p_Text, VNIVowels, true);
					case FontEnum.VIQR:
						//' Each VIQR vowel might take 2 or 3 characters. Read VIQR Vowels into a String Array
						//' Convert the Text from Unicode to VNI, using look-up one Unicode vowel corresponds
						//'     to a VIQR Vowel in a String Array
						return UnicodeToMultichar(p_Text, VIQRVowels, false);
				}
			else
			{
				//get here if we're to convert FROM another encoding to Unicode
				switch (fromEncoding)
				{
					case FontEnum.VPS:
						//	Convert the Text from VPS to Unicode, using one-to-one look-up
						return StringToString(p_Text, VPSVowels, strUnicodeVowels);
					case FontEnum.VISCII:
						//	Convert the Text from VISCII to Unicode, using one-to-one look-up
						return StringToString(p_Text, VISCIIVowels, strUnicodeVowels);
					case FontEnum.TCVN:
						//	Convert the Text from TCVN to Unicode, using one-to-one look-up
						return StringToString(p_Text, TCVNVowels, strUnicodeVowels);

					case FontEnum.VNI:
						//	Convert from VNI vowels to Unicode vowels
						return MulticharToUnicode(p_Text, VNIVowelMap);
					case FontEnum.VIQR:
						//	Convert from VIQR vowels to Unicode vowels
						return MulticharToUnicode(p_Text, VIQRVowelMap);
				}
			}
			return "";
		}
	}
}
