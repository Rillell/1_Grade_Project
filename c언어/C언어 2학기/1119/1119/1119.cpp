//����ü: �ϳ��� ����(�޸�)�� ���� �ٸ� �� ������ ���� ����ϴ°� 
//ū �޸𸮸� ��Ƴ��� �� ���� ����� ���� => ����ü�ʹ� �ٸ�.       ������ 


//����
#include<stdio.h>
void main()
{
	
	FILE *rfp;
    char s[20];
	rfp = fopen("c:\\soft\\data.1.txt", "r"); //�б� ����   w=>�������� a(affend)=> �߰��ϴ� ��

	fgets(s, 19, rfp);
	printf("���Ͽ��� ���� ���ڿ� :");
	puts(s);
	fgets(s, 19, rfp);
	printf("���Ͽ��� ���� ���ڿ� :");
	puts(s);
	fclose(rfp);
}