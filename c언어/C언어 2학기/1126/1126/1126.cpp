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

	printf("���� : ");
	scanf("%s", ss.name);
	printf("���� : ");
	scanf("%d", &ss.age);
	printf("��ȭ��ȣ : ");
	scanf("%s", ss.tel);

	wfp = fopen("d:\\soft\\data5.txt", "a"); //w :���ο� ���� ����+ �����߰�, ���������� �ִ��� ���ְ� ���Ӱ� ����
	//w �� a�� ����� ���� ���Ͽ� ���� �߰�, ���� ������ ������ ���ϻ����� ���� 
	fprintf(wfp, "%s\t%d\t%s\n", ss.name, ss.age, ss.tel);
	fclose(wfp);
}