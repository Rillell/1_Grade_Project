#include<stdio.h>
void main()
{
	int date, year, month, day;
	
		
	printf("년월일: ");
	scanf("%d", &date);

	year = date / 10000;
	date = date % 10000;
	month = date / 100;
	day = date % 100;



	printf("%d년 %d월 %d일\n", year, month, day);

}