#include<stdio.h>
//�Լ�����
int hap(int n1, int n2); //�����Ϸ����� �˷���

void main()
{
	int result;
	int su1, su2;
	printf("����2�� �Է�: ");
	scanf("%d%d", &su1, &su2);
	result = hap(su1, su2); //�Լ��� ȣ��
	printf("������� : %d\n", result);
}

//�Լ��� ����
int hap(int n1, int n2) 
{
	int res;
	res = n1 + n2;
	return res;
}