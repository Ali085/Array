using System;

int B = 1;
int M = 2;
int C = 12;
int D = 6;
int K = 18;
int count = 0;

if (B > 0) {
    if (B % 6 == 0) {
        count += B;

    } }
if (M > 0)
{
    if (M % 6 == 0)
    {
        count += M;

    } }
if (C > 0)
{
    if (C % 6 == 0)
    {
        count += C;

    } }
if (D > 0)
{
    if (D % 6 == 0)
    {
        count += D;

    } }
if (K > 0)
{
    if (K % 6 == 0)
    {
        count += K;

    }
}
Console.WriteLine(count);


