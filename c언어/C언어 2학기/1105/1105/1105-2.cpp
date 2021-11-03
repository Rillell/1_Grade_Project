#include<stdio.h>
void main()
{
		struct STUDENT
		{
			char name[10];
			int kor;
			int eng;
			int math;
			int all;
			float avg;
		};
		STUDENT std;

		printf("성명을 입력하세요 : ");
		scanf("%s", std.name);
		printf("성적 : ");
		scanf("%d%d%d", &std.kor, &std.eng, &std.math);

		std.all = std.kor + std.eng + std.math;
		std.avg = (float)std.all / 3;

		printf("\n=============================================\n");
		printf("성명\t국어\t영어\t수학\t총점\t평균\n");
		printf("----------------------------------------------\n");
		printf("%s\t%d\t%d\t%d\t%d\t%.2f\n", std.name, std.kor, std.eng, std.math, std.all, std.avg);
		printf("----------------------------------------------\n");




}