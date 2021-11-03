#include<stdio.h>
void main()
{
	struct student
	{
		char name[20];
		int kor;
		int eng;
		int math;
		int all;
		float avg;
	};
	struct student std[5];
	int i;
	for (i = 0; i < 5; i++)
	{
		printf("성명 : ");
		scanf("%s", std[i].name);
		printf("성적 : ");
		scanf("%d%d%d", &std[i].kor, &std[i].eng, &std[i].math);

		std[i].all = std[i].kor + std[i].eng + std[i].math;
		std[i].avg = (float)std[i].all / 3;
	}

	printf("\n=============================================\n");
	printf("성명\t국어\t영어\t수학\t총점\t평균\n");
	printf("----------------------------------------------\n");
	printf("%s\t%d\t%d\t%d\t%d\t%.2f\n", std[i].name, std[i].kor, std[i].eng, std[i].math, std[i].all, std[i].avg);
	printf("----------------------------------------------\n");

}