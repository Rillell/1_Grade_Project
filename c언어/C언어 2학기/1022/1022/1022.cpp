#include<stdio.h>
void main()
//{
//	int num = 10;
//	int *p;               //int는 *p에 있는 주솟값의 내용값이 정수형이라는 것이다.
//	p = &num;
//
//	printf("%d  %d   %p   %p  %p\n", num, *p, &num, p, &p);
//	num = 100;
//	printf("%d  %d   %p   %p  %p\n", num, *p, &num, p, &p);
//	*p = 123;
//	printf("%d  %d   %p   %p  %p\n", num, *p, &num, p, &p);
//
//}

{
	//p를 덧셈을 했을 때 대상체 크기를 횟수만큼 더한다.
	double ch = 100;
	double *p;
	double i;
	p = &ch;

	for (i = 0; i < 100; i++)
	{
		
		printf("%p => %d\n", p, *p);
		p = p + 2;
	}
}

//{
//	char ch = 'A';
//	char *p;
//	int i;
//	p = &ch;
//
//	for (i = 0; i < 100; i++)
//	{
//		printf("%p => %x\n", p, *p);  //%x => 16진수  
//		p = p + 3;
//	}
//}