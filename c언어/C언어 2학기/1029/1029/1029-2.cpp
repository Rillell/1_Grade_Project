#include<stdio.h>
void swap(int *x, int *y);

void main()
{
	int num1, num2;
	printf("�μ��� �Է��ϼ��� : ");
	scanf("%d%d", &num1, &num2);
	printf("num1 :%3d, num2 :%3d\n", num1, num2);
	printf("====swap �Լ� ȣ��====\n");
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
// call by reference : �ΰ� �̻��� �� ���� , return�� ������ ���� => ex)swap�Լ� 
// call by value : �� �� ������ �� ����, return�� ����