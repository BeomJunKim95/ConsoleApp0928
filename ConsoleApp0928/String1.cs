using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
	class String1
	{
		static void Main(string[] args)
		{
			string[] days = new string[7] { "일", "월", "화", "수", "목", "금", "토" };
			//days 배열의 내용을 콘솔로 출력

			#region 일반적인 문자열 연결방법
			//string str = string.Empty;
			//for(int i= 0;i<days.Length;i++)
			//{
			//	//Console.Write(days[i]+", ");
			//	str += days[i] + ","; // 문자열을 합할때 이렇게 더하기로 해주면 가비지가 많이 생김
			//}
			////str = str.Substring(0, str.Length - 2); // ,뒤 공백 때문에 -2
			//Console.WriteLine(str.TrimEnd(',')); // 요즘 코드 : TrimEnd 메서드를 알면 위에 다필요없음
			// TrimEnd :	
			// TrimStart, Trim
			#endregion
			#region 문자열 연결 한줄 코드 (string.Join() 메서드)
			string result = string.Join(",", days); //Join : string.Join("구분자", 배열명 ) => 배열안의 모든 요소를 포문없이 구분자로 연결 
													//Join은 정적 메서드라 클래스명으로 호출
			Console.WriteLine(result);
			#endregion

			#region 문자열을 분할해 배열에 저장 ( Split() 메서드 )
			string fruits = "딸기, 배, 사과, 포도";
			//좋아하는 과일의 내용을 배열에 저장

			string[] arr = fruits.Split(','); // Split() : 인스턴스명.Split('구분자') => 문자열을 파라미터의 구분자로 배열안으로 분할해서 넣어줌
			Console.WriteLine(arr.Length);
			Console.WriteLine(string.Join(",", arr));
			#endregion

			#region Split()메서드를 이용해 문자열을 입력받아 배열을만들어 연산
			//더하고자 하는 숫자들을 콘솔로 입력받아서
			//합을 구하여 콘솔로 출력
			//예를 들어서 10 50 60 44 55 24 77 =>320

			//Console.Write("더하고자 하는 숫자들을 입력해주세요: ");
			//string input = Console.ReadLine(); // 10 50 60 44 55 24 77

			//char[] delimiters = {',', ' ', '-' }; //new안하고 바로 값을 줘도 생성가능
			////string[] nums = input.Split(' ');
			//string[] nums = input.Split(delimiters); //구분자를 여러개 두고싶을때 char배열을 만들어서 배열을 줘도 가능
			//int sum = 0;
			//foreach(string num in nums)
			//{
			//	sum += int.Parse(num);
			//}
			//Console.WriteLine(sum);
			#endregion

			#region StringComparison인자
			fruits = "이것이 JAVA다.";
			Console.WriteLine(fruits.IndexOf("Java")); // -1 문자열을 찾지 못했다는 뜻
			Console.WriteLine(fruits.Contains("Java")); //false

			Console.WriteLine(fruits.IndexOf("Java",StringComparison.OrdinalIgnoreCase)); // 4 => 4번째에 자바가있다
			Console.WriteLine(fruits.ToLower().IndexOf("Java".ToLower())); //위와 같은결과
			#endregion

			#region 스트링포맷 정렬
			//정렬 : 번호와 대응되는 문자열의 너비를 지정하고 정렬값이 음수면 왼쪽 양수면 오른쪽 정렬을 한다
			for (int i= 1; i<10; i++)
			{
				//Console.WriteLine("5 * {0} = {1,2}", i,i * 5); // {1,2) => 2자리로 출력하는데 오른쪽정렬을해라
				Console.WriteLine($"5 * {i} = {i*5,-2}"); // -2니까 2자리로 왼쪽정렬
			}
			#endregion

			//숫자형 포맷과 날짜형 포맷
			//숫자형 
			// N : 1000단위로 쉼표 , C : 통화단위 , F : 고정소수점 
			//날짜형 
			// d : 단축날짜 , D : 상세날짜 , t : 단축시간 , T : 상세시간
			Console.WriteLine("날짜 : {0,-20:D}\n판매수량 : {1,15:N}", DateTime.Now, 1234567);
		}
	}
}
