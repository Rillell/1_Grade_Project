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

		printf("������ �Է��ϼ��� : ");
		scanf("%s", std.name);
		printf("���� : ");
		scanf("%d%d%d", &std.kor, &std.eng, &std.math);

		std.all = std.kor + std.eng + std.math;
		std.avg = (float)std.all / 3;

		printf("\n=============================================\n");
		printf("����\t����\t����\t����\t����\t���\n");
		printf("----------------------------------------------\n");
		printf("%s\t%d\t%d\t%d\t%d\t%.2f\n", std.name, std.kor, std.eng, std.math, std.all, std.avg);
		printf("----------------------------------------------\n");




}