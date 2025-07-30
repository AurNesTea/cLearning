function getCurrentTab(callback) {
  chrome.tabs.query({ active: true, currentWindow: true }, function (tabs) {
    callback(tabs[0]);
  });
}

// Copy Data
document.getElementById('copy').addEventListener('click', () => {
  getCurrentTab((tab) => {
    chrome.scripting.executeScript({
      target: { tabId: tab.id },
      func: () => {
        let course_name = document.querySelector('#course_name')?.value || '';
        let course_subtitle = document.querySelector('#course_subtitle')?.value || '';
        let course_slug = document.querySelector('#course_slug')?.value || '';
        let lecturer = document.querySelector('.css-12jo7m5')?.textContent || '';
        
        
        let course_category = '';
        let trys = document.querySelectorAll('.css-12jo7m5');
        trys.forEach(t => {
          if (t.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.innerText.includes('課程類別')) {
            course_category = t.textContent.trim();
          } 
        });

        
        let cat_labels = document.querySelectorAll('label');
        for (let label of cat_labels) {
            if (label.textContent.trim() === '課程類別') {
                // 找到 label 後，從這個 label 開始往後找第一個符合條件的元素
                let next = label.nextElementSibling;
                while (next) {
                    if (next.matches('.css-1hwfws3')) {
                        course_category = next.textContent.trim();
                        break;
                    }
                    next = next.nextElementSibling;
                }
                break; // 找到就不再繼續檢查其他 label
            }
        }

        let course_description = document.querySelector('.ck-content')?.innerHTML || '';
        let course_learning_objectives = document.querySelector('#course_learning_objectives').textContent || '';
        
        const data = {
          course_name,
          course_subtitle,
          course_slug,
          lecturer,
          course_category,
          course_description,
          course_learning_objectives
        };
        return data; // 把 data 回傳到 extension
      }
    }, (injectionResults) => {
      const [result] = injectionResults;
      if (result && result.result) {
        // 存到 chrome.storage.local
        chrome.storage.local.set({ pageData: result.result }, () => {
          alert('已複製T台資料！');
        });
      }
    });
  });
});

// Paste Data
document.getElementById('paste').addEventListener('click', () => {

  paste_double();
  // setTimeout(() => {
  //   paste_double();
  // }, 1000);
  setTimeout(() => {
    paste_double();
  }, 2000);
  setTimeout(() => {
    chrome.storage.local.remove('pageData', () => {
        // alert('已清空T台資料！');
      });
  }, 3000);



});

function paste_double() {

  chrome.storage.local.get('pageData', (result) => {
    const data = result.pageData;
    if (data) {
      getCurrentTab((tab) => {
        chrome.scripting.executeScript({
          target: { tabId: tab.id },
          func: (injectedData) => {
            console.clear();
            console.log('Pasted Data:', injectedData);
            window.t_data = injectedData; // 方便直接用

            // 課程名稱
              function f1() {
                let formItems = document.querySelectorAll('.ant-form-item-label label');
                let input繁1 = null;
                formItems.forEach(label => {
                    if (label.textContent.includes('課程名稱')) {
                        // 找到課程名稱這一組
                        const formItem = label.closest('.ant-form-item');
                        // 找到所有「繁」的 input
                        const spans = formItem.querySelectorAll('.ant-input-group-addon');
                        spans.forEach(span => {
                            if (span.textContent.trim() === '繁') {
                                // 取得「繁」後面的 input
                                input繁1 = span.parentElement.querySelector('input');
                            }
                        });
                    }
                });
                // 2. 設定 value
                if (input繁1) {
                    input繁1.value = injectedData.course_name;
                    input繁1.focus();
                    input繁1.setSelectionRange(input繁1.value.length, input繁1.value.length);
                    input繁1.dispatchEvent(new KeyboardEvent('keydown', { key: 'x', code: 'KeyX', bubbles: true }));
                    input繁1.value += 'x';
                    input繁1.dispatchEvent(new Event('input', { bubbles: true }));
                    input繁1.dispatchEvent(new KeyboardEvent('keyup', { key: 'x', code: 'KeyX', bubbles: true }));
                    input繁1.dispatchEvent(new KeyboardEvent('keydown', { key: 'Backspace', code: 'Backspace', bubbles: true }));
                    input繁1.value = input繁1.value.slice(0, -1);
                    input繁1.dispatchEvent(new Event('input', { bubbles: true }));
                    input繁1.dispatchEvent(new KeyboardEvent('keyup', { key: 'Backspace', code: 'Backspace', bubbles: true }));
                }
                setTimeout(() => {
                  f2();
                }, 500); // 等待一秒，確保輸入完成
              }

            // 課程副標題
              function f2() {
                // 1. 找到標籤文字為 "(一刻) 課程副標題" 的 label
                let labels2 = document.querySelectorAll('.ant-form-item-label label');
                let input繁2 = null;
                labels2.forEach(label => {
                    if (label.textContent.trim() === '(一刻) 課程副標題') {
                        // 2. 找到這個 form item 區塊
                        const formItem = label.closest('.ant-form-item');
                        // 3. 在這個區塊內找 "繁" 的 input
                        const addons = formItem.querySelectorAll('.ant-input-group-addon');
                        addons.forEach(addon => {
                            if (addon.textContent.trim() === '繁') {
                                input繁2 = addon.parentElement.querySelector('input');
                            }
                        });
                    }
                });
                // 4. 指定 value
                if (input繁2) {
                    input繁2.value = injectedData.course_subtitle;
                    input繁2.focus();
                    input繁2.setSelectionRange(input繁2.value.length, input繁2.value.length);
                    input繁2.dispatchEvent(new KeyboardEvent('keydown', { key: 'x', code: 'KeyX', bubbles: true }));
                    input繁2.value += 'x';
                    input繁2.dispatchEvent(new Event('input', { bubbles: true }));
                    input繁2.dispatchEvent(new KeyboardEvent('keyup', { key: 'x', code: 'KeyX', bubbles: true }));
                    input繁2.dispatchEvent(new KeyboardEvent('keydown', { key: 'Backspace', code: 'Backspace', bubbles: true }));
                    input繁2.value = input繁2.value.slice(0, -1);
                    input繁2.dispatchEvent(new Event('input', { bubbles: true }));
                    input繁2.dispatchEvent(new KeyboardEvent('keyup', { key: 'Backspace', code: 'Backspace', bubbles: true }));
                }
                setTimeout(() => {
                  f3();
                }, 500); // 等待一秒，確保輸入完成
              }

            // 銷售網址   ／ (品牌館) 銷售網址
              function f3() {
                // 1. 找到標籤文字為 "(品牌館) 銷售網址" 的 label
                let labels1 = document.querySelectorAll('.ant-form-item-label label');
                let inputEl = null;
                labels1.forEach(label => {
                    if (label.textContent.trim() === '(品牌館) 銷售網址') {
                        // 2. 找到這個 form item 區塊
                        const formItem = label.closest('.ant-form-item');
                        // 3. 在這個區塊內找 input
                        inputEl = formItem.querySelector('input');
                    }
                });
                // 4. 指定 value
                if (inputEl) {
                    inputEl.value = injectedData.course_slug;
                    inputEl.focus();
                    inputEl.setSelectionRange(inputEl.value.length, inputEl.value.length);
                    inputEl.dispatchEvent(new KeyboardEvent('keydown', { key: 'x', code: 'KeyX', bubbles: true }));
                    // inputEl.value += 'x';
                    inputEl.dispatchEvent(new Event('input', { bubbles: true }));
                    inputEl.dispatchEvent(new KeyboardEvent('keyup', { key: 'x', code: 'KeyX', bubbles: true }));
                    inputEl.dispatchEvent(new KeyboardEvent('keydown', { key: 'Backspace', code: 'Backspace', bubbles: true }));
                    // inputEl.value = inputEl.value.slice(0, -1);
                    inputEl.dispatchEvent(new Event('input', { bubbles: true }));
                    inputEl.dispatchEvent(new KeyboardEvent('keyup', { key: 'Backspace', code: 'Backspace', bubbles: true }));
                }
                setTimeout(() => {
                  f4();
                }, 500); // 等待一秒，確保輸入完成
              }

            // 課程簡介   ／ (品牌館) 課程簡介(繁)
              function f4() {
                // 1. 找到標籤文字為 "(品牌館) 課程簡介(繁)" 的 label
                let editors = document.querySelectorAll('.ql-editor');
                editors[8].innerHTML = injectedData.course_description;
                setTimeout(() => {
                  f5();
                }, 500); // 等待一秒，確保輸入完成
              }

            // 課程要點   ／ (品牌館) 課程要點(繁)
              function f5() {
                // 1. 找到標籤文字為 "(品牌館) 課程要點(繁)" 的 label
                const labels = document.querySelectorAll('.ant-form-item-label label');
                let textarea = null;
                labels.forEach(label => {
                    if (label.textContent.trim() === '(品牌館) 課程要點(繁)') {
                        // 2. 找到這個 form item 區塊
                        const formItem = label.closest('.ant-form-item');
                        // 3. 在這個區塊內找 textarea
                        textarea = formItem.querySelector('textarea');
                    }
                });
                // 4. 指定 textarea 的內容
                if (textarea) {
                    textarea.value = injectedData.course_learning_objectives;
                    textarea.focus();
                    textarea.setSelectionRange(textarea.value.length, textarea.value.length);
                    textarea.dispatchEvent(new KeyboardEvent('keydown', { key: 'x', code: 'KeyX', bubbles: true }));
                    textarea.value += 'x';
                    textarea.dispatchEvent(new Event('input', { bubbles: true }));
                    textarea.dispatchEvent(new KeyboardEvent('keyup', { key: 'x', code: 'KeyX', bubbles: true }));
                    textarea.dispatchEvent(new KeyboardEvent('keydown', { key: 'Backspace', code: 'Backspace', bubbles: true }));
                    textarea.value = textarea.value.slice(0, -1);
                    textarea.dispatchEvent(new Event('input', { bubbles: true }));
                    textarea.dispatchEvent(new KeyboardEvent('keyup', { key: 'Backspace', code: 'Backspace', bubbles: true }));
                } 
                setTimeout(() => {
                  f6();
                }, 500); // 等待一秒，確保輸入完成
              }
              
            // 講師
              function f6() {
                console.log('主播/講師：', injectedData.lecturer);
                f7();
              }
              
            // 課程類別
              function f7() {
                console.log('課程分類：', injectedData.course_category);
              }

            f1();
            
            // alert('已貼上T台資料！');
          },
          args: [data] // 把 data 傳到頁面
        });
      });
    } else {
      // alert('No data found.');
    }
  });

}