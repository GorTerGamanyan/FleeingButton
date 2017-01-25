# FleeingButton
Button on which it is impossible to hover.

```C#
private void button1_MouseMove(object sender, MouseEventArgs e)
{
    Random rnd = new Random();

    button1.Location = new Point(rnd.Next(0, 1100), rnd.Next(0, 600));
}
```
