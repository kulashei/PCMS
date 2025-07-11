using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Factories;

namespace CMS.Extensions
{
    public static class DxGridExtensions
    {
        public static DataGridBuilder<T> DefaultGridProperties<T>(this DataGridBuilder<T> builder)
        {
            return builder.Width("100%")
                .Height(460)
                .ShowBorders(true)
                .AllowColumnReordering(false)
                .RowAlternationEnabled(true)
                .ShowColumnLines(true)
                .FocusedRowEnabled(true)
                .SearchPanel(searchPanel => searchPanel
                    .Width(240)
                    .Visible(true)
                    .Placeholder("Search...")
                )
                .Selection(s => s.Mode(SelectionMode.Single))
                .Editing(e => e
                    .AllowAdding(true)
                    .AllowUpdating(true)
                    .AllowDeleting(true)
                )
                .Paging(p => p.PageSize(20))
                .Pager(p => p
                    .ShowPageSizeSelector(true)
                    .AllowedPageSizes([20, 25, 50, 100])
                    .ShowInfo(true)
                    .InfoText("Page {0} of {1} | Total Items: {2}")
                );
        }

        public static ButtonBuilder CustomToolButton(this ToolbarItemFactory builder)
        {
            return builder.Button()
                .Type(ButtonType.Default)
                .StylingMode(ButtonStylingMode.Contained)
                .HoverStateEnabled(true);
        }

        public static DataGridEditingBuilder<T> EnableAllCrud<T>(this DataGridEditingBuilder<T> builder)
        {
            return builder
                .AllowAdding(true)
                .AllowUpdating(true)
                .AllowDeleting(true);
        }

        public static DataGridBuilder<T> DefaultToolBar<T>(this DataGridBuilder<T> builder)
        {
            return builder
                .Toolbar(t => t
                    .Items(items =>
                    {
                        items.Add()
                            .Name("addRowButton")
                            .Location(ToolbarItemLocation.Before)
                            .ShowText(ToolbarItemShowTextMode.Always)
                            .Widget(w => w.CustomToolButton()
                                .Text("Add New") 
                            );

                        items.Add()
                            .Location(ToolbarItemLocation.After)
                            .Widget(w => w.CustomToolButton()
                                .Text("Refresh")
                                .Icon("fa-solid fa-arrows-rotate") 
                            );

                        items.Add().Name("searchPanel");
                    })
                );
        }
    }
}