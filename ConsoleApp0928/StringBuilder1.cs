using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
	class StringBuilder1
	{
		static void Main()
		{
			#region StringBuilder
			DateTime dtStart = DateTime.Now;

			//string txt = "Hello World";
			//for(int i =0; i<3000;i++)
			//{
			//	txt += i;
			//}
			// 스트링 빌더로 처리 해보자
			StringBuilder sb = new StringBuilder(); //명시적으로 항상 new하고 써야함
			sb.Append("Hello World"); // StringBuilder의 더하기는 Append()
			for (int i = 0; i < 3000; i++)
			{
				sb.Append(i);
			}
			//결론 : 스트링 빌더가 속도가 더빠르다

			DateTime dtEnd = DateTime.Now;
			double interval = (dtEnd - dtStart).TotalMilliseconds;

			Console.WriteLine(interval);
			#endregion

			#region 기존 문자열을 합해주는 방법을 StringBuilder로
			//string str = string.Empty;
			//for(int i= 0;i<days.Length;i++)
			//{
			//	//Console.Write(days[i]+", ");
			//	str += days[i] + ","; // 문자열을 합할때 이렇게 더하기로 해주면 가비지가 많이 생김
			//}

			string[] days = new string[7] { "일", "월", "화", "수", "목", "금", "토" };
			//StringBuilder sb1 = new StringBuilder(); //스트링빌더를 새로 만들어도 되고
			sb.Clear(); // Clear를 통해 내용들을 모두 지우고 기존 인스턴스를 다시 써도 된다 , 전체 삭제
			sb.Remove(0, sb.Length); // 일부분을 삭제할때 사용
			
			foreach(string temp in days)
			{
				//sb.Append(temp + ",");
				sb.AppendFormat("{0},", temp);// append와 포맷 합쳐짐
				//sb.AppendLine(temp);// 한줄씩 줄바꿈
			}
			Console.WriteLine(sb.ToString().Trim(',')); // StringBuilder를 ToString을 통해 string으로 변환
														//StringBuilder가 일반적인 방법보다 가비지가 안생기고 더 빠르고 좋음
			Console.WriteLine(sb.Remove(sb.Length-1,1));//끝에 쉼표를 이렇게 지울수도 있음

			
			#endregion
		}
	}
}
