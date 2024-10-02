function moKhungChat() {
    document.getElementById('khungChat').style.display = 'flex';
    document.getElementById('nutMoKhungChat').style.display = 'none';
}

function dongKhungChat() {
    document.getElementById('khungChat').style.display = 'none';
    document.getElementById('nutMoKhungChat').style.display = 'block';
}

function guiTinNhan() {
    var tinNhan = document.getElementById('inputTinNhan').value;
    if (tinNhan.trim() !== '') {
        var khungChatContent = document.getElementById('khungChatContent');
        var tinNhanHtml = '<div class="tin-nhan"><p>' + tinNhan + '</p></div>';
        khungChatContent.innerHTML += tinNhanHtml;
        document.getElementById('inputTinNhan').value = '';
        khungChatContent.scrollTop = khungChatContent.scrollHeight;
    }
}

document.getElementById('inputTinNhan').addEventListener('keypress', function(e) {
    if (e.key === 'Enter') {
        guiTinNhan();
    }
});
