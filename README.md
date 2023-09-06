# how-to-show-a-.net-maui-popup-when-tap-.net-maui-listview-item

This example shows how to show a .NET MAUI Popup when tap .NET MAUI ListView item

## XAML 
   <Grid>
            <sfListView:SfListView  x:Name="listView" ItemSize="56"
                                    ItemsSource="{Binding Items}" 
                                    SelectionMode="None"
                                    ItemTapped="ListView_ItemTapped">
                <sfListView:SfListView.ItemTemplate>
                    <DataTemplate>
                       ---

                       ---
                    </DataTemplate>
                </sfListView:SfListView.ItemTemplate>
            </sfListView:SfListView>

            <sfPopup:SfPopup x:Name="sfPopup" 
                         WidthRequest="220" HeightRequest="120"
                         ShowCloseButton="True">
                <sfPopup:SfPopup.ContentTemplate>
                    <DataTemplate>
                        <Label Text="ListView item is tapped"                           
                           TextColor="Black"
                           FontSize="14"
                           FontFamily="Roboto"/>
                    </DataTemplate>
                </sfPopup:SfPopup.ContentTemplate>
            </sfPopup:SfPopup>
        </Grid>

## C#

private void ListView_ItemTapped(object sender, Syncfusion.Maui.ListView.ItemTappedEventArgs e)
{
	sfPopup.Show();
}

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.