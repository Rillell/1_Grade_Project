#include<stdio.h>
void main()
{
	FILE *rfp;
	int read, hap = 0;
	rfp = fopen("c:\\soft\\data2.txt","r");
	while (1)
	{
		fscanf(rfp, "%d", &read);
		if (feof(rfp)) break;		
		hap += read;
		printf("%3d + ", read);
		//if (feof(rfp)) break; =>끝에 같은숫자 하나 더 추가됨
	}
	printf("\b\b = %d\n", hap);
	//printf("\nhap = %d\n", hap);
	fclose(rfp);
}