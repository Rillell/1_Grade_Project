#include<stdio.h>
void main()
//{
//	int num = 10;
//	int *p;               //int�� *p�� �ִ� �ּڰ��� ���밪�� �������̶�� ���̴�.
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
	//p�� ������ ���� �� ���ü ũ�⸦ Ƚ����ŭ ���Ѵ�.
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
//		printf("%p => %x\n", p, *p);  //%x => 16����  
//		p = p + 3;
//	}
//}