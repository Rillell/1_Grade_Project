#include<stdio.h>
//함수선언
int hap(int n1, int n2); //컴파일러에게 알려줌

void main()
{
	int result;
	int su1, su2;
	printf("정수2개 입력: ");
	scanf("%d%d", &su1, &su2);
	result = hap(su1, su2); //함수의 호출
	printf("덧셈결과 : %d\n", result);
}

//함수의 정의
int hap(int n1, int n2) 
{
	int res;
	res = n1 + n2;
	return res;
}