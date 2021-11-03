#include<stdio.h>
#include<Windows.h>
void FIn(); 
void FOut();
void FSearch();





void main()
{
    int num;
	while (1)
	{
		system("cls");
		printf("\n\n\n");
		printf("\t1.입금\n\n");
		printf("\t2.출금\n\n");
		printf("\t3.조회\n\n");
		printf("\t0.종료\n\n");
		printf("\t .....[  ]\b\b");
		scanf("%d", &num);

		if (num == 0) break;
		switch (num)
		{
		case 1: FIn(); break;
		case 2: FOut(); break;
		case 3: FSearch(); break;
		default: printf("잘못 입력하셨습니다.\n");
			system("pause");
		}
	}
}

	
void FIn()
{
	FILE *rfp;
	struct FIn
	{
		char date[20];
		char why[14];
		int money;
	} s;

	system("cls");
	printf("\n\n");
	printf("\t수입\n");

	printf("날짜 : ");
	scanf("%s", s.date);
	printf("적요 : ");
	scanf("%s", s.why);
	printf("금액 : ");
	scanf("%d", &s.money);

	rfp = fopen("d:\\soft\\In.txt", "a");
	fprintf(rfp, "%s\t%s\t%d\n", s.date, s.why, s.money);
	fclose(rfp);
	system("pause");
}
void FOut()
{
	FILE *rfp;
	struct FOut
	{
		char date[20];
		char why[14];
		int money;
	}s;

	system("cls");
	printf("\n\n");
	printf("\t지출\n");
	
	printf("날짜 : ");
	scanf("%s", s.date);
	printf("적요 : ");
	scanf("%s", s.why);
	printf("금액 : ");
	scanf("%d", &s.money);

	rfp = fopen("d:\\soft\\Out.txt", "a");
	fprintf(rfp, "%s\t%s\t%d\n", s.date, s.why, s.money);
	fclose(rfp);
	system("pause");
}
void FSearch()
{
	FILE *rfp;
	struct FOut
	{
		char date[20];
		char why[14];
		int money;
	} s;

	system("cls");
	printf("\n");
	printf("\t조회\n");
	printf("\n");
	printf("================================\n");
	printf("날짜\t적요\t금액\t구분\n");
	printf("--------------------------------\n");

	rfp = fopen("d:\\soft\\In.txt", "r");
	while (1)
	{
		fscanf(rfp, "%s%s%d", s.date, s.why, &s.money);
		if (feof(rfp))break;
		printf("%s\t%s\t%d\t임금\n", s.date, s.why, s.money);
	}
	fclose(rfp);
	
	rfp = fopen("d:\\soft\\Out.txt", "r");
	while (1)
	{
		fscanf(rfp, "%s%s%d", s.date, s.why, &s.money);
		if (feof(rfp))break;
		printf("%s\t%s\t%d\t출력\n", s.date, s.why, s.money);
	}
	fclose(rfp);

	printf("--------------------------------\n");
	system("pause");
}