#include<stdio.h>
void main()
{

	FILE *rfp;
	char s[100];
	rfp = fopen("c:\\windows\\win.ini", "r");

	while (1)
	{
		fgets(s, 99, rfp);
		if (feof(rfp)) break; //������ ó������ ������ �о ���������� �о��� ��쿡 break�ض�.
		printf("%s\n", s);
	}
	fclose(rfp);
}
