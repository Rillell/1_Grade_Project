#include<stdio.h>
void main()
{
	FILE *wfp;
	struct sinsang
	{
		char name[20];
		int age;
		char tel[14];
	} ss;

	printf("성명 : ");
	scanf("%s", ss.name);
	printf("나이 : ");
	scanf("%d", &ss.age);
	printf("전화번호 : ");
	scanf("%s", ss.tel);

	wfp = fopen("d:\\soft\\data5.txt", "a"); //w :새로운 파일 생성+ 내용추가, 기존파일이 있더라도 없애고 새롭게 생성
	//w 를 a로 만들면 기존 파일에 내용 추가, 기존 파일이 없으면 파일생성도 가능 
	fprintf(wfp, "%s\t%d\t%s\n", ss.name, ss.age, ss.tel);
	fclose(wfp);
}