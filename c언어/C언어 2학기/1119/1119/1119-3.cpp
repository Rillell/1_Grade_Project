#include<stdio.h>
void main()
{
	FILE *rfp;
	int read1, read2;
	rfp = fopen("c:\\soft\\data3.txt", "r");
	while (1)
	{
		fscanf(rfp, "%d%d", &read1, &read2);
		if (feof(rfp)) break;
		printf("%3d + %3d = %3d\n", read1, read2, read1 + read2);
	}
	fclose(rfp);
}

//#include<stdio.h>
//void main()
//{
//	FILE *rfp;
//	int read1, read2 ,result;
//	char giho;
//	rfp = fopen("c:\\soft\\data4.txt", "r");
//	while (1)
//	{
//		fscanf(rfp, "%d %d %c", &read1, &read2 ,&giho);
//		if (feof(rfp)) break;
//		switch (giho)
//		{
//		case '+': result = read1 + read2; break;
//		case '-': result = read1 - read2; break;
//		case '*': result = read1 * read2; break;
//		case '/': result = read1 / read2; break;
//		}
//		printf("%3d %c %3d = %3d\n", read1, giho, read2, result);
//	}
//	fclose(rfp);
//}