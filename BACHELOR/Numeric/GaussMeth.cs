<Gauss>
int m;
vector<vector<double>> A(m, vector<double>(m));//левая часть(коэфф. при иксах)
vector<double> F(m);//правая часть(свободные члены)
//прямой ход
for (int i = 0; i < m - 1; ++i)//проход по подматрицам
	for (int j = i + 1; j < m; ++j)//по строкам
	{
		double coeff = -A[i][i] / A[j][i];
		F[j] *= coeff;
		F[j] += F[i];
		for (int k = i; k < m; ++k)//по столбцам
		{
			A[j][k] *= coeff;
			A[j][k] += A[i][k];
		}
	}

//обратный ход
vector<double> X(m);
for (int i = m - 1; i >= 0; --i)
{
	X[i] = F[i] / A[i][i];
	for (int j = i + 1; j < m; ++j)
		X[i] -= X[j] * A[i][j] / A[i][i];
}
</Gauss>

