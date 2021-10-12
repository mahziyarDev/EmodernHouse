function ShowMessage(title, text, theme) {
    window.createNotification({
        closeOnClick: true,
        displayCloseButton: false,
        positionClass: 'nfc-bottom-right',
        showDuration: 7000,
        theme: theme !== '' ? theme : 'success'

    })({
        title: title !== '' ? title : 'اعلان',
        message: decodeURI(text)
    });
}

/*for ckEditors*/


$(document).ready(function () {
    var editors = $("[ckeditor]");
    if (editors.length > 0) {
        $.getScript('/js/ckeditor.js',
            function () {
                $(editors).each(function (index, value) {
                    var id = $(value).attr('ckeditor');
                    ClassicEditor.create(document.querySelector('[ckeditor="' + id + '"]'),
                        {
                            toolbar: {
                                items: [
                                    'heading',
                                    '|',
                                    'bold',
                                    'italic',
                                    'link',
                                    '|',
                                    'fontSize',
                                    'fontColor',
                                    '|',
                                    'imageUpload',
                                    'blockQuote',
                                    'insertTable',
                                    'undo',
                                    'redo',
                                    'codeBlock'
                                ]
                            },
                            language: 'fa',
                            table: {
                                contentToolbar: [
                                    'tableColumn',
                                    'tableRow',
                                    'mergeTableCells'
                                ]
                            },
                            licenseKey: '',
                            simpleUpload: {
                                // The URL that the images are uploaded to.
                                uploadUrl: '/Uploader/UploadImage'
                            }

                        })
                        .then(editor => {
                            window.editor = editor;
                        }).catch(err => {
                            console.error(err);
                        });
                });
            });
    }
});

$('[ajax-url-button]').on('click', function (e) {
    e.preventDefault();
    var url = $(this).attr('href');
    var itemId = $(this).attr('ajax-url-button');
    console.log(itemId);
    swal({
        title: 'اخطار',
        text: "آیا از انجام عملیات مورد نظر اطمینان دارید؟",
        type: "warning",
        showCancelButton: true,
        confirmButtonClass: "btn-danger",
        confirmButtonText: "بله",
        cancelButtonText: "خیر",
        closeOnConfirm: false,
        closeOnCancel: false
    }).then((result) => {
        if (result.value) {
            $.get(url).then(result => {
                if (result.status === 'Success') {
                    ShowMessage("موفقیت", result.message, "success", 3000);
                    $('#ajax-url-item-' + itemId).hide(1500);
                }
            });
        } else if (result.dismiss === swal.DismissReason.cancel) {
            swal('توجه', 'عملیات لغو شد', 'error');
        }
    });
});

//for categories 
$(document).ready(function () {
   // $('[main_categories_checkbox]>div').hide();
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



$(document).ready(function () {


    $('#submitFormEdit').on('click',
        function () {
            e.preventDefault();
            $("#EditForm").submit();
        });
});