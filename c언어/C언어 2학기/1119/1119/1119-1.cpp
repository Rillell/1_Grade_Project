#include<stdio.h>
void main()
{

	FILE *rfp;
	char s[100];
	rfp = fopen("c:\\windows\\win.ini", "r");

	while (1)
	{
		fgets(s, 99, rfp);
		if (feof(rfp)) break; //파일을 처음부터 끝까지 읽어서 마지막까지 읽었을 경우에 break해라.
		printf("%s\n", s);
	}
	fclose(rfp);
}
