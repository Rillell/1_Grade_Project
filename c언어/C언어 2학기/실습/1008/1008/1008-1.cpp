#include<stdio.h>
/*void main()
{
	int n[5] = { 10, 20, 30, 40, 50 };
	int *p;
	p = n;

	printf("%d\n",*p);
	p = p + 1;
	printf("%d\n", *p);
}*/

void main()
{
	int n; //정수가 들어갈 수 있는 공간 확보
	int *p;// 주소가 들어갈 수 있는 변수 p 확보
	       // 주소를 찾아가면 정수형 data가 있음
	p = &n;//변수와 포인터 변수를 연결
           //변수의 주소를 포인터 변수의 data로 보냄
	n = 10;
	printf("%d  %d\n", n, *p);
	*p = n + 20;
	printf("%d  %d\n", n, *p);

}      