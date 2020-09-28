using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
	class Endcoding1
	{
		static void Main()
		{
			//string name = Console.ReadLine();
			//Console.WriteLine(name);

			string str = "Hello 안녕";
			Console.WriteLine("기본문장 : " + str);

			//UTF8 형식으로 인코딩한 배열로 변환
			byte[] result1 = Encoding.UTF8.GetBytes(str);
			PrintByteArray(result1);
			Console.WriteLine(Encoding.UTF8.GetString(result1)); //정상출력
			Console.WriteLine(Encoding.Unicode.GetString(result1)); //글자가 깨짐 (인코딩타입이 달라서 오류)

			//Unicode 형식으로 인코딩한 배열로 변환
			//영어든 한글이든 모두 2바이트로 인식
			byte[] result2 = Encoding.Unicode.GetBytes(str);
			PrintByteArray(result2);
			Console.WriteLine(Encoding.UTF8.GetString(result2));//글자가 깨짐

			//ASCII 형식으로 인코딩한 배열로 변환
			//한글불가 한글은 깨짐
			byte[] result3 = Encoding.ASCII.GetBytes(str);
			PrintByteArray(result3);

		}

		private static void PrintByteArray(byte[] result3) //계속 쓰니 메서드 추출로 편리하게
		{
			foreach (byte b in result3)
			{
				Console.Write($"{b},");
			}
			Console.WriteLine();
		}
	}
}
