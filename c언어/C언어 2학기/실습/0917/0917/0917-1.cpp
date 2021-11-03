//배열: 연속적인 메모리 공간, 동일한 데이터 타입

//정수7개가 들어갈수 있는 배열(arr)을 만들고 21~77사이의 난수를 채우고 출력하시오
/*#include<stdio.h>
#include<stdlib.h>
#include<time.h>
void main()
{
	int arr[7] = { 0 };
	int i, rnum;
	
	srand((unsigned)time(NULL));
	
	for (i = 0; i < 7; i++)
	{
		rnum = rand() % (77-21+1) + 21;
		arr[i] = rnum;
	}
	for (i = 0; i < 7; i++)
		printf("%5d", arr[i]);
	printf("\n\n");
}*/





//정수7개가 들어갈수 있는 배열(arr)을 만들고 21~77사이의 난수를 '중복없이' 채우고 출력하시오
#include<stdio.h>
#include<stdlib.h>
#include<time.h>
void main()
{
	int arr[7] = { 0 };
	int i,j, rnum, tmp;

	srand((unsigned)time(NULL));
	for (i = 0; i < 7; i++)
	{
		rnum = rand() % (77 - 21 + 1) + 21;
		//중복 배제하는 코드
		for (j = 0; arr[j] > 0; j++)
			if (rnum == arr[j]) break;
		if(arr[j]==0)  arr[i] = rnum;
		else           i--;
	}
	printf("발행 :");
	for (i = 0; i < 7; i++)
		printf("%5d", arr[i]);
	printf("\n\n");

	//숫자 순서대로 나열하는 코드(소트)
	for (i = 0; i < 6; i++)
	{
		for (j = i + 1; j < 7; j++)
		{
			if (arr[i] > arr[j])
			{
				tmp = arr[i];
				arr[i] = arr[j];
				arr[j] = tmp;
			}
		}
	}
	printf("소트 :");
	for (i = 0; i < 7; i++)
		printf("%5d", arr[i]);
	printf("\n\n");
}