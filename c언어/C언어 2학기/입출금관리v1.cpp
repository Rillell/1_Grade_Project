#include <stdio.h>
#include <Windows.h>
void FIn();
void FOut();
void FSearch();
void main()
{
	int sel;
	while (1)
	{
		system("cls");
		printf("\n\n\n\n");
		printf("\t 1. �Ա�\n\n");
		printf("\t 2. ���\n\n");
		printf("\t 3. ��ȸ\n\n");
		printf("\t 0. ����\n\n");
		printf("\t   .....[ ]\b\b");
		scanf("%d", &sel);
		if (sel == 0) break;
		switch (sel)
		{
		case 1: FIn(); break;
		case 2: FOut(); break;
		case 3: FSearch(); break;
		default: printf("�߸��Է��ϼ̽��ϴ�\n\n");
			system("pause");
		}
	}
	printf("\n\n");
}

void FIn()
{
	struct moneyInOut
	{
		char ymd[6];
		char memo[20];
		int  money;
	} s;
	FILE *wfp;

	system("cls");
	printf("\n\n\n");
	printf("\t   �� ��\n\n");
	printf("\n\t ��¥ : ");
	scanf("%s", s.ymd);
	printf("\n\t ���� : ");
	scanf("%s", s.memo);
	printf("\n\t �ݾ� : ");
	scanf("%d", &s.money);

	wfp = fopen("d:\\soft\\in.txt", "a");
	fprintf(wfp, "%s %s %d\n", s.ymd, s.memo, s.money);
	fclose(wfp);

	system("pause");
}
void FOut()
{
	struct moneyInOut
	{
		char ymd[6];
		char memo[20];
		int  money;
	} s;
	FILE *wfp;

	system("cls");
	printf("\n\n\n");
	printf("\t   �� ��\n\n");
	printf("\n\t ��¥ : ");
	scanf("%s", s.ymd);
	printf("\n\t ���� : ");
	scanf("%s", s.memo);
	printf("\n\t �ݾ� : ");
	scanf("%d", &s.money);

	wfp = fopen("d:\\soft\\out.txt", "a");
	fprintf(wfp, "%s %s %d\n", s.ymd, s.memo, s.money);
	fclose(wfp);

	system("pause");
}
void FSearch()
{
	struct moneyInOut
	{
		char ymd[6];
		char memo[20];
		int  money;
	} s;
	FILE *rfp;
	int intot = 0, outtot = 0;
	
	system("cls");
	printf("\n\n\n");
	printf("\t �� ȸ\n\n");

	printf("====================================\n");
	printf("��¥\t����\t�Ա�\t���\t����\n");
	printf("------------------------------------\n");
	rfp = fopen("d:\\soft\\in.txt", "r");
	while (1)
	{
		fscanf(rfp, "%s%s%d", s.ymd, s.memo, &s.money);
		if (feof(rfp)) break;
		printf("%s\t%s\t%7d\t\t�Ա�\n", s.ymd, s.memo, s.money);
		intot += s.money;
	}
	fclose(rfp);
	rfp = fopen("d:\\soft\\out.txt", "r");
	while (1)
	{
		fscanf(rfp, "%s%s%d", s.ymd, s.memo, &s.money);
		if (feof(rfp)) break;
		printf("%s\t%s\t\t%7d\t���\n", s.ymd, s.memo, s.money);
		outtot += s.money;
	}
	fclose(rfp);

	printf("------------------------------------\n");
	printf("\t\t%7d\t%7d\t%7d\n", intot, outtot, intot - outtot);
	printf("------------------------------------\n");

	system("pause");
}