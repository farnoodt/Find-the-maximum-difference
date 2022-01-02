// See https://aka.ms/new-console-template for more information
int[] A = { 2, 7, 9, 5, 1, 3, 5 };

int diff = getMaxDiff(A);
if (diff != int.MinValue)
{
    Console.WriteLine("The maximum difference is " + diff);
}

static int getMaxDiff(int[] A)
{
    int diff = int.MinValue;
    int n = A.Length;

    if (n == 0)
    {
        return diff;
    }
    int max_so_far = A[n - 1];

    // traverse the array from the right and keep track of the maximum element
    for (int i = n - 2; i >= 0; i--)
    {
        // update `max_so_far` if the current element is greater than the
        // maximum element
        if (A[i] >= max_so_far)
        {
            max_so_far = A[i];
        }
        // if the current element is less than the maximum element,
        // then update the difference if required
        else
        {
            diff = Math.Max(diff, max_so_far - A[i]);
        }
    }

    // return difference
    return diff;
}