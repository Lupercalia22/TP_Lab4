using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using static System.Net.WebRequestMethods;
using static System.Net.Mime.MediaTypeNames;

namespace Filename.ext
{
	internal class Program
	{
	static string SpisokPapok(string Name)
		{
			List<string> papki = new List<string>();
			var dn = Path.GetDirectoryName(Name);
			dn = dn.Substring(dn.LastIndexOf('\\')+1);
			papki.Add(dn);
			foreach (string papky in papki)
			{
				Console.WriteLine(papky);
			}
			return Name;
			
		}
		static void Main(string[] args)
		{
	        string fileName = @"C:\Users\darya\Desktop\инж\molotok.m3d";
			string fileName1 = @"C:\Users\darya\Desktop\фх\FX2.py";
			string fileName2 = @"C:\Users\darya\Desktop\пи\two.txt";
			string fileName3 = @"C:\Users\darya\Desktop\веб\index.css";
			string fileName4 = @"https://translate.google.com/";
			string fileName5 = @"https://mail.google.com/";

			string result = Path.GetFileName(fileName); 
			Console.WriteLine("{1}",fileName, result);

			string raschir = Path.GetExtension(fileName); ;
			Console.WriteLine("extension: " + raschir);

			string[] mas = new string[3];
			mas[0] = fileName1;
			Console.WriteLine(mas[0]);


			SpisokPapok(fileName);
			SpisokPapok(fileName1);
			SpisokPapok(fileName2);
			SpisokPapok(fileName3);

			FileInfo test = new FileInfo(@"C:\Users\darya\Desktop\пи\two.txt");
			string ind = test.Name;
			FileInfo test1 = new FileInfo(@"C:\Users\darya\Desktop\фх\FX2.py");
			string ind1 = test1.Name;
			FileInfo test2 = new FileInfo(@"C:\Users\darya\Desktop\веб\index.css");
			string ind2 = test2.Name;
			FileInfo test3 = new FileInfo(@"C:\Users\darya\Desktop\инж\molotok.m3d");
			string ind3 = test3.Name;
			List<string> Name = new List<string>();
			Name.Add(ind);
			Name.Add(ind1);
			Name.Add(ind2);
			Name.Add(ind3);
			Name.Sort();
			foreach (string str in Name)
				Console.WriteLine(str);


		}
	}
}
