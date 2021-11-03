#include<stdio.h>
void swap(int *x, int *y);

void main()
{
	int num1, num2;
	printf("두수를 입력하세요 : ");
	scanf("%d%d", &num1, &num2);
	printf("num1 :%3d, num2 :%3d\n", num1, num2);
	printf("====swap 함수 호출====\n");
	swap(&num1, &num2);
	printf("num1 :%3d , num2 :%3d\n", num1, num2);

}

void swap(int *x, int*y)
{
	int tmp;
	tmp = *x;
	*x = *y;
	*y = tmp;
}
// call by reference : 두개 이상의 값 전달 , return값 없을수 있음 => ex)swap함수 
// call by value : 한 개 이하의 값 전달, return값 존재