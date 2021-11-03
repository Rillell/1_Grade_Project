#include <stdio.h>
#include <string.h>
#include <Windows.h>
void FIn();
void FOut();
void FSearch();
void FFileOut();
void FDayToDay();
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
		printf("\t 4. �������\n\n");
		printf("\t 5. �Ⱓ��ȸ\n\n");
		printf("\t 0. ����\n\n");
		printf("\t   .....[ ]\b\b");
		scanf("%d", &sel);
		if (sel == 0) break;
		switch (sel)
		{
			case 1: FIn(); break;		
			case 2: FOut(); break;
			case 3: FSearch(); break;
			case 4: FFileOut(); break;
			case 5: FDayToDay(); break;
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
	printf("\t   ���� ��\n\n");
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
	} inmoney, outmoney;
	FILE *rfp1, *rfp2;    //  ��¥�� ��Ʈ�ǰ� �Ϸ��� ���ϵ� ���� ���ÿ� open �Ѵ�
	int intot = 0, outtot = 0;
	bool inchk = true, outchk = true;

	system("cls");
	printf("\n\n\n");
	printf("\t �� ȸ\n\n");

	printf("=======================================\n");
	printf("��¥\t����\t�Ա�\t���\t����\n");
	printf("---------------------------------------\n");
	rfp1 = fopen("d:\\soft\\in.txt", "r");
	rfp2 = fopen("d:\\soft\\out.txt", "r");

	fscanf(rfp1, "%s%s%d", inmoney.ymd, inmoney.memo, &inmoney.money);
	fscanf(rfp2, "%s%s%d", outmoney.ymd, outmoney.memo, &outmoney.money);

	while (1)
	{

		if ((strcmp(inmoney.ymd, outmoney.ymd) <= 0) && inchk)
		{
			printf("%s\t%s\t%7d\t\t�Ա�\n", inmoney.ymd, inmoney.memo, inmoney.money);
			intot += inmoney.money;
			fscanf(rfp1, "%s%s%d", inmoney.ymd, inmoney.memo, &inmoney.money);
			if (feof(rfp1)) {
				inchk = false;
				strcpy(inmoney.ymd, "99-99");
			}
		}
		else if ((strcmp(inmoney.ymd, outmoney.ymd) > 0) && outchk)
		{
			printf("%s\t%s\t\t%7d\t���\n", outmoney.ymd, outmoney.memo, outmoney.money);
			outtot += outmoney.money;
			fscanf(rfp2, "%s%s%d", outmoney.ymd, outmoney.memo, &outmoney.money);
			if (feof(rfp2))
			{
				outchk = false;
				strcpy(outmoney.ymd, "99-99");
			}
		}
		if (!(outchk) && !(inchk)) break;
	}

	fclose(rfp1);
	fclose(rfp2);
	printf("---------------------------------------\n");
	printf("\t\t%7d%7d\t%7d\n", intot, outtot, intot - outtot);
	printf("---------------------------------------\n");

	system("pause");
}

void FFileOut()
{
	struct moneyInOut
	{
		char ymd[6];
		char memo[20];
		int  money;
	} inmoney, outmoney;
	FILE *rfp1, *rfp2;    //  ��¥�� ��Ʈ�ǰ� �Ϸ��� ���ϵ� ���� ���ÿ� open �Ѵ�
	FILE *wfp;
	int intot = 0, outtot = 0;
	bool inchk = true, outchk = true;
	wfp = fopen("d:\\soft\\fileout.txt", "w");

	system("cls");
	fprintf(wfp,"\n\n\n");
	fprintf(wfp, "\t �� ȸ\n\n");

	fprintf(wfp, "=======================================\n");
	fprintf(wfp, "��¥\t����\t�Ա�\t���\t����\n");
	fprintf(wfp, "---------------------------------------\n");
	rfp1 = fopen("d:\\soft\\in.txt", "r");
	rfp2 = fopen("d:\\soft\\out.txt", "r");

	fscanf(rfp1, "%s%s%d", inmoney.ymd, inmoney.memo, &inmoney.money);
	fscanf(rfp2, "%s%s%d", outmoney.ymd, outmoney.memo, &outmoney.money);

	while (1)
	{
		if ((strcmp(inmoney.ymd, outmoney.ymd) <= 0) && inchk)
		{
			fprintf(wfp, "%s\t%s\t%7d\t\t�Ա�\n", inmoney.ymd, inmoney.memo, inmoney.money);
			intot += inmoney.money;
			fscanf(rfp1, "%s%s%d", inmoney.ymd, inmoney.memo, &inmoney.money);
			if (feof(rfp1)) {
				inchk = false;
				strcpy(inmoney.ymd, "99-99");
			}
		}
		else if ((strcmp(inmoney.ymd, outmoney.ymd) > 0) && outchk)
		{
			fprintf(wfp, "%s\t%s\t\t%7d\t���\n", outmoney.ymd, outmoney.memo, outmoney.money);
			outtot += outmoney.money;
			fscanf(rfp2, "%s%s%d", outmoney.ymd, outmoney.memo, &outmoney.money);
			if (feof(rfp2))
			{
				outchk = false;
				strcpy(outmoney.ymd, "99-99");
			}
		}
		if (!(outchk) && !(inchk)) break;
	}

	fclose(rfp1);
	fclose(rfp2);
	fprintf(wfp, "---------------------------------------\n");
	fprintf(wfp, "\t\t%7d%7d\t%7d\n", intot, outtot, intot - outtot);
	fprintf(wfp, "---------------------------------------\n");

	fclose(wfp);

	printf("\n\n\t���� ����� �Ϸ��Ͽ����ϴ�\n\n");

	system("pause");
}

void FDayToDay()
{
	struct moneyInOut
	{
		char ymd[6];
		char memo[20];
		int  money;
	} inmoney, outmoney;
	FILE *rfp1, *rfp2;    //  ��¥�� ��Ʈ�ǰ� �Ϸ��� ���ϵ� ���� ���ÿ� open �Ѵ�
	int intot = 0, outtot = 0;
	char Sday[6], Eday[6];
	bool inchk = true, outchk = true;

	system("cls");
	printf("\n\n\n");
	printf("\t �� ȸ\n\n");

	printf("��ȸ������ : ");
	scanf("%s",Sday);
	printf("��ȸ������ : ");
	scanf("%s", Eday);


	printf("=======================================\n");
	printf("��¥\t����\t�Ա�\t���\t����\n");
	printf("---------------------------------------\n");
	rfp1 = fopen("d:\\soft\\in.txt", "r");
	rfp2 = fopen("d:\\soft\\out.txt", "r");

	fscanf(rfp1, "%s%s%d", inmoney.ymd, inmoney.memo, &inmoney.money);
	fscanf(rfp2, "%s%s%d", outmoney.ymd, outmoney.memo, &outmoney.money);

	while (1)
	{

		if ((strcmp(inmoney.ymd, outmoney.ymd) <= 0) && inchk)
		{
			if (strcmp(inmoney.ymd, Sday) >= 0 && strcmp(inmoney.ymd, Eday) <= 0)
			{
				printf("%s\t%s\t%7d\t\t�Ա�\n", inmoney.ymd, inmoney.memo, inmoney.money);
				intot += inmoney.money;
			}
			fscanf(rfp1, "%s%s%d", inmoney.ymd, inmoney.memo, &inmoney.money);
			if (feof(rfp1)) {
				inchk = false;
				strcpy(inmoney.ymd, "99-99");
			}
		}
		else if ((strcmp(inmoney.ymd, outmoney.ymd) > 0) && outchk)
		{
			if (strcmp(outmoney.ymd, Sday) >= 0 && strcmp(outmoney.ymd, Eday) <= 0)
			{
				printf("%s\t%s\t\t%7d\t���\n", outmoney.ymd, outmoney.memo, outmoney.money);
				outtot += outmoney.money;
			}
			fscanf(rfp2, "%s%s%d", outmoney.ymd, outmoney.memo, &outmoney.money);
			if (feof(rfp2))
			{
				outchk = false;
				strcpy(outmoney.ymd, "99-99");
			}
		}
		if (!(outchk) && !(inchk)) break;
	}

	fclose(rfp1);
	fclose(rfp2);
	printf("---------------------------------------\n");
	printf("\t\t%7d%7d\t%7d\n", intot, outtot, intot - outtot);
	printf("---------------------------------------\n");

	system("pause");

}