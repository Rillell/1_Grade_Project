#include<stdio.h>
void main()
{
	int date, year, month, day;
	
		
	printf("�����: ");
	scanf("%d", &date);

	year = date / 10000;
	date = date % 10000;
	month = date / 100;
	day = date % 100;



	printf("%d�� %d�� %d��\n", year, month, day);

}