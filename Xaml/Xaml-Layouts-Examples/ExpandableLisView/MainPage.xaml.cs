private void ListView_OnItemTapped(object sender, ItemTapEventArgs e)
{
    if (e.Item is BookItemViewModel book)
    {
        book.ShowDetails = !book.ShowDetails;
    }
}