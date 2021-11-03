#include<stdio.h>
void func_all();
void func_menu();
void func_inmoney();
void see_inmoney();
void func_outmoney();
void see_outmoney();


int inmoney[100][2] = { {0101,12000 },{0215,12345} };
char inwork[100][50] = { "�׽�Ʈ1","�׽�Ʈ2" };
int outmoney[100][2] = { { 0101,12000 },{ 0215,12345 } };
char outwork[100][50] = { "�׽�Ʈ1","�׽�Ʈ2" };
int in = 0, out = 0;

void main()
{
	func_all();
    func_menu();
}

void func_all()
{
int inmoney_hqp = 0, outmoney_hqp = 0;
inmoney_hqp += inmoney[in][1];
outmoney_hqp += outmoney[out][1];
printf("\n\n");
printf("\t\t\t\t����/���� ����\n");
printf("\t\t\t====================================\n");
printf("\t\t\t�����Ѿ�\t�����Ѿ�\t�ܾ�\n\n");
printf("\t\t\t------------------------------------\n");
printf("\t\t\t%d\t\t%5d\t%10d\n", inmoney_hqp, outmoney_hqp, inmoney_hqp - outmoney_hqp);
printf("\t\t\t====================================\n");
printf("\n\n");
}

void func_menu()
{
	int num;
	printf("[Menu]\n");
	while (1)
	{					
		printf("\n1.��   ��\t2.��   ��\t3.���� ��ȸ\t4.���� ��ȸ\n");
		printf("\n-------------------------------------------------------[  ]\b\b");
		scanf("%d", &num);

		if (num == 0) break;
		switch (num)
		{
		case 1: func_inmoney(); break;
		case 2: func_outmoney(); break;
		case 3: see_inmoney(); break;
		case 4: see_outmoney(); break;
		default: printf("�߸� �Է��ϼ̽��ϴ�.\n");
		}
	}
}

void func_inmoney()
{
	printf("\n\n");
		printf("\t\t\t****************************\n");
		printf("\t\t\t***       �����Է�       ***\n");
		printf("\t\t\t****************************\n");

		printf("\t\t\t��¥ : ");
		scanf("%d", &inmoney[in][0]);
		printf("\t\t\t�ݾ� : ");
		scanf("%d", &inmoney[in][1]);
		printf("\t\t\t���� : ");
		scanf("%s", &inwork[in]);
		in++;
}

void see_inmoney()
{
	int intotalmoney = 0;
	printf("\n\n");
	printf("\t\t\t*************************************\n");
	printf("\t\t\t***           ���� ��ȸ           ***\n");
	printf("\t\t\t*************************************\n");
	printf("\t\t\t��¥\t\t�ݾ�\t\t�� ��\n");
	printf("\t\t\t-------------------------------------\n");

	for (int i = 0; i < in; i++)
	{
		printf("\t\t\t%d/%d\t\t%d\t\t%s\n", inmoney[i][0] / 100, inmoney[i][0] % 100, inmoney[i][1], inwork[i]);
		intotalmoney += inmoney[i][1];
	}
	printf("\t\t\t-------------------------------------\n");
	printf("\t\t\t[total: %d]\n", intotalmoney);

}
void func_outmoney()
{
	printf("\n\n");
	printf("\t\t\t****************************\n");
	printf("\t\t\t***       �����Է�       ***\n");
	printf("\t\t\t****************************\n");

	printf("\t\t\t��¥ : ");
	scanf("%d", &outmoney[out][0]);
	printf("\t\t\t�ݾ� : ");
	scanf("%d", &outmoney[out][1]);
	printf("\t\t\t���� : ");
	scanf("%s", &outwork[out]);
	out++;
}
void see_outmoney()
{
	int outtotalmoney = 0;
	printf("\n\n");
	printf("\t\t\t*************************************\n");
	printf("\t\t\t***           ���� ��ȸ           ***\n");
	printf("\t\t\t*************************************\n");
	printf("\t\t\t��¥\t\t�ݾ�\t\t�� ��\n");
	printf("\t\t\t-------------------------------------\n");

	for (int j = 0; j < out; j++)
	{
		printf("\t\t\t%d/%d\t\t%d\t\t%s\n", outmoney[j][0] / 100, outmoney[j][0] % 100, outmoney[j][1], outwork[j]);
		outtotalmoney += outmoney[j][1];
	}
	printf("\t\t\t-------------------------------------\n");
	printf("\t\t\t[total: %d]\n", outtotalmoney);
}


