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
		printf("\t1.�Ա�\n\n");
		printf("\t2.���\n\n");
		printf("\t3.��ȸ\n\n");
		printf("\t0.����\n\n");
		printf("\t .....[  ]\b\b");
		scanf("%d", &num);

		if (num == 0) break;
		switch (num)
		{
		case 1: FIn(); break;
		case 2: FOut(); break;
		case 3: FSearch(); break;
		default: printf("�߸� �Է��ϼ̽��ϴ�.\n");
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
	printf("\t����\n");

	printf("��¥ : ");
	scanf("%s", s.date);
	printf("���� : ");
	scanf("%s", s.why);
	printf("�ݾ� : ");
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
	printf("\t����\n");
	
	printf("��¥ : ");
	scanf("%s", s.date);
	printf("���� : ");
	scanf("%s", s.why);
	printf("�ݾ� : ");
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
	printf("\t��ȸ\n");
	printf("\n");
	printf("================================\n");
	printf("��¥\t����\t�ݾ�\t����\n");
	printf("--------------------------------\n");

	rfp = fopen("d:\\soft\\In.txt", "r");
	while (1)
	{
		fscanf(rfp, "%s%s%d", s.date, s.why, &s.money);
		if (feof(rfp))break;
		printf("%s\t%s\t%d\t�ӱ�\n", s.date, s.why, s.money);
	}
	fclose(rfp);
	
	rfp = fopen("d:\\soft\\Out.txt", "r");
	while (1)
	{
		fscanf(rfp, "%s%s%d", s.date, s.why, &s.money);
		if (feof(rfp))break;
		printf("%s\t%s\t%d\t���\n", s.date, s.why, s.money);
	}
	fclose(rfp);

	printf("--------------------------------\n");
	system("pause");
}