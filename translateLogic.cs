using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections;
using System.Web.Script.Serialization;
using System.Globalization;

namespace LogicTranslator
{
    public class translateLogic
	{
		public string TranslateText(string input,string from,string to)
		{
			// Set the language from/to in the url (or pass it into this function)
			string url = String.Format
			("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
			 from, to, Uri.EscapeUriString(input));
			HttpClient httpClient = new HttpClient();
			string result = httpClient.GetStringAsync(url).Result;

			// Get all json data
			var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);

			// Extract just the first array element (This is the only data we are interested in)
			var translationItems = jsonData[0];

			// Translation Data
			string translation = "";

			// Loop through the collection extracting the translated objects
			foreach (object item in translationItems)
			{
				// Convert the item array to IEnumerable
				IEnumerable translationLineObject = item as IEnumerable;

				// Convert the IEnumerable translationLineObject to a IEnumerator
				IEnumerator translationLineString = translationLineObject.GetEnumerator();

				// Get first object in IEnumerator
				translationLineString.MoveNext();

				// Save its value (translated text)
				translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
			}

			// Remove first blank character
			if (translation.Length > 1) { translation = translation.Substring(1); };

			// Return translation
			return translation;
		}

		public List<string> GetLanguage()
		{
			List<string> list = new List<string>();
			foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
			{
				string specName = "(none)";
				try { specName = CultureInfo.CreateSpecificCulture(ci.Name).Name; } catch { }
				list.Add(ci.EnglishName);
			}
			list.Sort();
			return list;
		}
	}
}
