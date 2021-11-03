#include<stdio.h>
void main()
/*{
	int score;
	char ch;
	printf("점수: ");
	scanf("%d", &score);

	if (score >= 90)
		ch = 'A';
	else if(score >= 80)
		ch = 'B';
	else if (score >= 70)
		ch = 'C';
	else if (score >= 60)
		ch = 'D';
	else
		ch = 'F';

	printf("점수%d는 %c 학점 입니다\n", score, ch);

}*/



{
	int score;
	char ch;
	printf("점수: ");
	scanf("%d", &score);
	switch (score/10)
	{
	case 10:
	case 9: printf("A\n"); break;
	case 8: printf("B\n"); break;
	case 7: printf("C\n"); break;
	case 6: printf("D\n"); break;
		default: printf("F\n"); break;
			

	}
}
