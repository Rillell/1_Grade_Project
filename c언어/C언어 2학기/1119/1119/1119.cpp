//공용체: 하나의 공간(메모리)을 서로 다른 두 변수가 같이 사용하는것 
//큰 메모리를 잡아놓고 그 위로 덮어쓰는 형태 => 구조체와는 다름.       열거형 


//파일
#include<stdio.h>
void main()
{
	
	FILE *rfp;
    char s[20];
	rfp = fopen("c:\\soft\\data.1.txt", "r"); //읽기 형식   w=>쓰기형식 a(affend)=> 추가하는 것

	fgets(s, 19, rfp);
	printf("파일에서 읽은 문자열 :");
	puts(s);
	fgets(s, 19, rfp);
	printf("파일에서 읽은 문자열 :");
	puts(s);
	fclose(rfp);
}