using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
	class FileInfo1
	{
		static void Main()
		{
			string from = "ConsoleApp0928.exe.config";
			string to = "myConfig.txt";

			FileInfo fromFile = new FileInfo(from); //FileInfo는 인스턴스 메서드 

			if (fromFile.Exists)
			{
				FileInfo toFile = fromFile.CopyTo(to, true);

				string to2222 = "C:/Temp2/MyFolder/myConfig_33333.txt";

				fromFile.MoveTo(to);
			}
		}
	}
}
