#include<stdio.h>
void main()
//{
//	char str1[10] = "Seoil"; // 문자열 배열 : 쓸대없는 4바이트의 공간이 더 들어간다.
//	char *str2 = "Seoil"; // 문자열 포인터 : 시작되는 주소를 가지고 간다. 메모리의 낭비가 없다.
//
//	printf("%s    %s", str1, str2);
//}

{
	int n = 10;
	int *p1;
	int **p2;

	p1 = &n;
	p2 = &p1;

	printf("%d    %d    %d\n", n, *p1, **p2);

	printf("%p  %p  %p  %p  %p", &n, p1, &p1, p2, &p2);

}