//����� ���� �ڷ��� => ����ü
#include<stdio.h>
void main()
{
	struct STUDENT
	{
		char hakbun[6];
		char name[10];
		char dept[10];
		int age;
		int hakyy;
		int hakjum;
		double grade;
	};

	int num = 10;
	struct STUDENT std2, std1 = { "S1901","ȫ�浿","�Ұ���",20,1,21 };
	std2 = std1; //������ ���� Ÿ���� ������ ������ ���� �ű�� �ִ�. But,����� �ȵȴ�.
	printf("%s   %s\n", std1.name, std2.name); //�̸��� ���.

	printf("%d   %d\n", sizeof(struct STUDENT), sizeof(std1)); //����ü�� ũ��� �� �ִ� ��� ������ ���� ū ��� ex)double���� ������ 8�ǹ��, int���� ������ 4�ǹ��

}

//{
//	struct STUDENT
//	{
//		char hakbun[6];
//		char name[20];
//		char dept[20];
//		int age;
//		int hakyy;
//		int hakjum;
//		float grade;
//	};
//	STUDENT std1; //struct�� ��������
//	printf("�й� : ");
//	scanf("%s", std1.hakbun); //�迭�̱� ������ &�� �Ⱥٿ��� �ȴ�.
//	printf("���� : ");
//	scanf("%s", std1.name);
//	printf("�а� : ");
//	scanf("%s", std1.dept);
//	printf("���� : ");
//	scanf("%d", &std1.age);
//	printf("�г� : ");
//	scanf("%d", &std1.hakyy);
//	printf("������� : ");
//	scanf("%d", &std1.hakjum);
//	printf("���� : ");
//	scanf("%f", &std1.grade);
//
//	printf("%s   %s   %s\n", std1.hakbun, std1.name, std1.dept);
//	printf("%d   %d   %d   %.2f\n", std1.age, std1.hakyy, std1.hakjum, std1.grade);
//
//}