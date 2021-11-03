/*//s1의 글자를 s2에 옮겨주는 코드
#include<stdio.h>
#include<string.h>
void main()
{
	char s1[10] = "Seoil";
	char s2[10];
	int addr;
	int i;
	//s2 = s1; 이와 같은 경우는 둘다 상수이기 때문에 성립되지 않는다.

	//for (i = 0; i < 10; i++)
		s2[i] = s1[i];//
	
	strcpy(s2, s1); //string.h안에 포함되는 함수

	printf("%s    %s\n", s1, s2);
}*/


//두 글자가 같은지 다른지 확인하는 코딩
/*#include<stdio.h>
#include<string.h>
void main()
{
	char s1[10] = "Seoil";
	char s2[10] = "Seoul";
	int i, chk=0;

	for (i = 0; i < 10; i++)
	{
		chk = s1[i] - s2[i];
		if (chk != 0) break;
	}

	if (chk) printf("같지 않다\n");
	else     printf("같다\n");
}*/

#include<stdio.h>
#include<string.h>
void main()
{
	char s1[10] = "Seoil";
	char s2[10] = "Seull";

	printf("%s   %s   %d\n", s1, s2, strcmp(s1, s2)); //앞의것에서 뒤의것을 뺀다.
}
