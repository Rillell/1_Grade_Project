#include<stdio.h>
void main()
{
	int n[5][5];
	int i, j, value = 0;
	int col, row;
	int *p;
	p = n[0];
	for (i = 0; i < 5; i++)
		for (j = 0; j < 5; j++)
			n[i][j] = value++;

	for (i = 0; i < 5; i++)
	{
		for (j = 0; j < 5; j++)
			printf("%5d", n[i][j]);
		printf("\n");
	}
	printf("\n 행 / 열 : ");
	scanf("%d%d", &col, &row);
	printf("n[%d][%d] : %d\n", col, row, n[col][row]);
	printf("n[%d][%d] : %d\n", col, row, *(p + (col *(sizeof(n[0])/ sizeof(n[0][0])) + row))); //sizeof(n[0])/ sizeof(n[0][0]) == 열의 개수
	printf("*(p+(%d*(%d / %d)+ %d : %d\n", col, sizeof(n[0]), sizeof(n[0][0]), row);
}
