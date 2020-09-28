using System;
using System.Collections.Generic;
using System.IO; //File클래스를 쓰기위해 반드시 추가
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
	class File1
	{
		static void Main()
		{
			string from = "ConsoleApp0928.exe.config";
			string to = "myConfig.txt";
			// 절대경로는 앞에 / or C:/으로 시작하는 두가지 경우만 해당
			//File.Copy(from, to); // 한번더 실행하면 System.IO.IOException 발생 
			// to 파일이 이미 있는 경우, 오류가 발생할 수 있다.
			if (File.Exists(from)) //체크
			{
				File.Copy(from, to, true); //덮어쓰기
				//string to2222 = "myConfig_33333.txt";
				//string to2222 = "../myConfig_33333.txt"; // ../ => 상위경로(상대경로)
				string to2222 = "C:/Temp2/MyFolder/myConfig_33333.txt"; //Temp폴더가 없어 System.IO.DirectoryNotFoundException발생
				if (!Directory.Exists("C:/Temp2/MyFolder")) //경로가 존재하지않으면 만들어주려고 체크하는것
				{											//디렉토리를 생성할때 서브디렉토리까지 입력하면 디렉토리까지는 생성해준다
															//하지만 파일은 아님
					Directory.CreateDirectory("C:/Temp2/MyFolder");
				}
				//File.Move(to, to2222);

				if (Directory.Exists("C:/Temp2/MyFolder")) // 디렉토리가 비어있지 않으면 디렉토리 삭제불가능
				{
					Directory.Delete("C:/Temp2/MyFolder", true);//true면 해당 디렉토리의 하위디렉토리및 파일 삭제
				}

				foreach(string item in Directory.GetFiles("./")) // ./ => exe가 있는 같은경로, 파일명 과 ./파일명은 같음
				{
					Console.WriteLine(item);
				}
			}
		}
	}
}
