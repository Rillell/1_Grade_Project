//사용자 정의 자료형 => 구조체
#include<stdio.h>
void main()
{
	struct STUDENT
	{
		char hakbun[6];
		char name[10];
		char dept[10];
		int age;
		int hakyy;
		int hakjum;
		double grade;
	};

	int num = 10;
	struct STUDENT std2, std1 = { "S1901","홍길동","소공과",20,1,21 };
	std2 = std1; //변수는 같은 타입의 데이터 형으로 값을 옮길수 있다. But,상수는 안된다.
	printf("%s   %s\n", std1.name, std2.name); //이름만 출력.

	printf("%d   %d\n", sizeof(struct STUDENT), sizeof(std1)); //구조체의 크기는 들어가 있는 멤버 변수의 가장 큰 배수 ex)double형이 있으면 8의배수, int형이 있으면 4의배수

}

//{
//	struct STUDENT
//	{
//		char hakbun[6];
//		char name[20];
//		char dept[20];
//		int age;
//		int hakyy;
//		int hakjum;
//		float grade;
//	};
//	STUDENT std1; //struct는 생략가능
//	printf("학번 : ");
//	scanf("%s", std1.hakbun); //배열이기 때문에 &을 안붙여도 된다.
//	printf("성명 : ");
//	scanf("%s", std1.name);
//	printf("학과 : ");
//	scanf("%s", std1.dept);
//	printf("나이 : ");
//	scanf("%d", &std1.age);
//	printf("학년 : ");
//	scanf("%d", &std1.hakyy);
//	printf("취득학점 : ");
//	scanf("%d", &std1.hakjum);
//	printf("평점 : ");
//	scanf("%f", &std1.grade);
//
//	printf("%s   %s   %s\n", std1.hakbun, std1.name, std1.dept);
//	printf("%d   %d   %d   %.2f\n", std1.age, std1.hakyy, std1.hakjum, std1.grade);
//
//}