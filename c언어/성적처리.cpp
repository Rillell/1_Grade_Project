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

char name[5][10] = { "홍길동", "김말동", "이기자", "최고야","나잘해" };
int  jum[5][6] = { 0 };

void main()
{
	jumsucalc(jum);   // 중간, 기말, 출석점수 생성
	totNhakjum(jum);  // 총점, 학점계산
	rankcalc(jum);    // 석차계산
	alldataprint(name, jum); // 출력
	FindMenu();	
}

void jumsucalc(int jum[][6])
{
	int i;
	srand((unsigned)time(NULL));
	for (i = 0; i < 5; i++)
	{   // 성명입력
		//		printf("성명을 입력하세요 : ");
		//		gets_s(name[i]);
		//랜덤함수 이용하여 중간,기말, 출석점수 만들기
		jum[i][0] = rand() % (40 - 20 + 1) + 20;  // 중간
		jum[i][1] = rand() % (40 - 20 + 1) + 20;  // 기말
		jum[i][2] = rand() % (20 - 10 + 1) + 10;  // 출석
	}
}

void totNhakjum(int jum[][6])
{
	int i, j;
	for (i = 0; i < 5; i++)
	{
		for (j = 0; j < 3; j++)
			jum[i][3] += jum[i][j];   // 총점계산
									  // jum[i][3] = jum[i][0]+jum[i][1]+jum[i][2];
									  //학점계산 : 65(A),66(B),67(C),68(D),70(F)
		switch (jum[i][3] / 10)
		{
		case 10:
		case 9:  jum[i][5] = 65; break;
		case 8:  jum[i][5] = 66; break;
		case 7:  jum[i][5] = 67; break;
		case 6:  jum[i][5] = 68; break;
		default:  jum[i][5] = 70;
		}
		if (jum[i][2] < 12) jum[i][5] = 70;  // 출석점수가 12점 미만이면 F
	}
}
void rankcalc(int jum[][6])
{
	int i, j;
	// 석차계산
	for (i = 0; i < 5; i++)  //석차계산 대상
	{
		jum[i][4] = 1;       // 현재는 1등
		for (j = 0; j < 5; j++)  //  모든사람과 비교하기 위한 반복
			if (jum[i][3] < jum[j][3]) jum[i][4]++; // 내 점수가 낮으면 등수에 1 더함
	}
}
void alldataprint(char name[][10], int jum[][6])
{
	int i, j;
	//출력
	printf("====================================================\n");
	printf("성명\t중간\t기말\t출석\t총점\t석차\t학점\n");
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
	printf("검색하고자 하는 석차를 입력하세요 [ ]\b\b");
	scanf("%d", &rank);
	chk = false;
	printf("====================================================\n");
	printf("성명\t중간\t기말\t출석\t총점\t석차\t학점\n");
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
	if (!chk) printf("  검색된 데이터가 없습니다\n");
	printf("----------------------------------------------------\n");

}
void nameFind(char name[][10], int jum[][6])
{
	int i, j;
	char tmpname[10];
	bool chk;
	printf("검색하고자 하는 이름 입력하세요 [        ]\b\b\b\b\b\b\b\b\b");
	scanf("%s", tmpname);
	chk = false;
	printf("====================================================\n");
	printf("성명\t중간\t기말\t출석\t총점\t석차\t학점\n");
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
	if (!chk) printf("  검색된 데이터가 없습니다\n");
	printf("----------------------------------------------------\n");
}

void FindMenu()
{
	int sel;
	printf(" =검색 메뉴= \n");
	while (1)
	{
		printf("\n 1. 순위검색 2. 성명검색 0. 종료 [ ]\b\b");
		scanf("%d", &sel);
		if (sel == 0) break;
		switch (sel)
		{
			case 1 : rankFind(name, jum); break;
			case 2 : nameFind(name, jum); break;
			default: printf("잘못입력하셨습니다\n");
		}
	}
}