int[] kettlebells = {1, 8, 3, 2, 6};
int max = 0;
for(int i = 0; i < kettlebells.Length; i++)
{
    if(kettlebells[i] > max)
    {
        max = kettlebells[i];
    }
}
Console.Write("max = ");
Console.Write(max);