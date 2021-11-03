#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string.h>

void jumsucalc(int jum[][6]);
void totNhakjum(int jum[][6]);
void rankcalc(int jum[][6]);
void alldataprint(char name[][10], int jum[][6]);
void rankFind(char name[][10], int jum[][6]);
void nameFind(char name[][10], int jum[][6]);
void FindMenu();

char name[5][10] = { "ȫ�浿", "�踻��", "�̱���", "�ְ��","������" };
int  jum[5][6] = { 0 };

void main()
{
	jumsucalc(jum);   // �߰�, �⸻, �⼮���� ����
	totNhakjum(jum);  // ����, �������
	rankcalc(jum);    // �������
	alldataprint(name, jum); // ���
	FindMenu();	
}

void jumsucalc(int jum[][6])
{
	int i;
	srand((unsigned)time(NULL));
	for (i = 0; i < 5; i++)
	{   // �����Է�
		//		printf("������ �Է��ϼ��� : ");
		//		gets_s(name[i]);
		//�����Լ� �̿��Ͽ� �߰�,�⸻, �⼮���� �����
		jum[i][0] = rand() % (40 - 20 + 1) + 20;  // �߰�
		jum[i][1] = rand() % (40 - 20 + 1) + 20;  // �⸻
		jum[i][2] = rand() % (20 - 10 + 1) + 10;  // �⼮
	}
}

void totNhakjum(int jum[][6])
{
	int i, j;
	for (i = 0; i < 5; i++)
	{
		for (j = 0; j < 3; j++)
			jum[i][3] += jum[i][j];   // �������
									  // jum[i][3] = jum[i][0]+jum[i][1]+jum[i][2];
									  //������� : 65(A),66(B),67(C),68(D),70(F)
		switch (jum[i][3] / 10)
		{
		case 10:
		case 9:  jum[i][5] = 65; break;
		case 8:  jum[i][5] = 66; break;
		case 7:  jum[i][5] = 67; break;
		case 6:  jum[i][5] = 68; break;
		default:  jum[i][5] = 70;
		}
		if (jum[i][2] < 12) jum[i][5] = 70;  // �⼮������ 12�� �̸��̸� F
	}
}
void rankcalc(int jum[][6])
{
	int i, j;
	// �������
	for (i = 0; i < 5; i++)  //������� ���
	{
		jum[i][4] = 1;       // ����� 1��
		for (j = 0; j < 5; j++)  //  ������� ���ϱ� ���� �ݺ�
			if (jum[i][3] < jum[j][3]) jum[i][4]++; // �� ������ ������ ����� 1 ����
	}
}
void alldataprint(char name[][10], int jum[][6])
{
	int i, j;
	//���
	printf("====================================================\n");
	printf("����\t�߰�\t�⸻\t�⼮\t����\t����\t����\n");
	printf("----------------------------------------------------\n");
	for (i = 0; i < 5; i++)
	{
		printf("%s\t", name[i]);
		for (j = 0; j < 5; j++)
			printf("%3d\t", jum[i][j]);
		printf("%c\n", jum[i][5]);
	}
	printf("----------------------------------------------------\n");

}

void rankFind(char name[][10], int jum[][6])
{
	int rank, i, j;
	bool chk;
	printf("�˻��ϰ��� �ϴ� ������ �Է��ϼ��� [ ]\b\b");
	scanf("%d", &rank);
	chk = false;
	printf("====================================================\n");
	printf("����\t�߰�\t�⸻\t�⼮\t����\t����\t����\n");
	printf("----------------------------------------------------\n");
	for (i = 0; i < 5; i++)
	{
		if (jum[i][4] == rank)
		{
			printf("%s\t", name[i]);
			for (j = 0; j < 5; j++)
				printf("%3d\t", jum[i][j]);
			printf("%c\n", jum[i][5]);
			chk = true;
		}
	}
	if (!chk) printf("  �˻��� �����Ͱ� �����ϴ�\n");
	printf("----------------------------------------------------\n");

}
void nameFind(char name[][10], int jum[][6])
{
	int i, j;
	char tmpname[10];
	bool chk;
	printf("�˻��ϰ��� �ϴ� �̸� �Է��ϼ��� [        ]\b\b\b\b\b\b\b\b\b");
	scanf("%s", tmpname);
	chk = false;
	printf("====================================================\n");
	printf("����\t�߰�\t�⸻\t�⼮\t����\t����\t����\n");
	printf("----------------------------------------------------\n");
	for (i = 0; i < 5; i++)
	{
		if (strcmp(name[i], tmpname) == 0)
		{
			printf("%s\t", name[i]);
			for (j = 0; j < 5; j++)
				printf("%3d\t", jum[i][j]);
			printf("%c\n", jum[i][5]);
			chk = true;
		}
	}
	if (!chk) printf("  �˻��� �����Ͱ� �����ϴ�\n");
	printf("----------------------------------------------------\n");
}

void FindMenu()
{
	int sel;
	printf(" =�˻� �޴�= \n");
	while (1)
	{
		printf("\n 1. �����˻� 2. ����˻� 0. ���� [ ]\b\b");
		scanf("%d", &sel);
		if (sel == 0) break;
		switch (sel)
		{
			case 1 : rankFind(name, jum); break;
			case 2 : nameFind(name, jum); break;
			default: printf("�߸��Է��ϼ̽��ϴ�\n");
		}
	}
}