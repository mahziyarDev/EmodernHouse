$(document).ready(function () {
    $('[main_categories_checkbox]>div').hide();
    $('[main_categories_checkbox]').on('change',
        function (e) {

            var IsChecked = $(this).is(':checked');
            var selectedCategoryId = $(this).attr('main_categories_checkbox');
            var SelectedLastCategoryId = $('[firs-parent-category]').attr('firs-parent-category');
            if (IsChecked) {
                $('#firs-parent-categories-' + selectedCategoryId).slideDown(300);
            } else {
                $('#firs-parent-categories-' + selectedCategoryId).slideUp(300);
                $('[firs-parent-category1="' + selectedCategoryId + '"]').prop('checked', false);
                $('#last-categories-' + SelectedLastCategoryId).slideUp(300);
                $('[two-parent-categories="' + SelectedLastCategoryId + '"]').prop('checked', false);
            }
        });

    $('[firs-parent-category]').on('change',
        function (e) {
            var isCheckedParent = $(this).is(':checked');
            var SelectedLastCategoryId = $(this).attr('firs-parent-category');
            if (isCheckedParent) {
                $('#last-categories-' + SelectedLastCategoryId).slideDown(300);
            } else {
                $('#last-categories-' + SelectedLastCategoryId).slideUp(300);
                $('[two-parent-categories="' + SelectedLastCategoryId + '"]').prop('checked', false);
            }
        });
});