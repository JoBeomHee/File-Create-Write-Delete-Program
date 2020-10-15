using System;
using System.IO;
using System.Windows.Forms;

namespace FileTest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //이벤트 선언
            InitEvent();
        }

        /// <summary>
        /// 각종 이벤트 선언 메서드
        /// </summary>
        private void InitEvent()
        {
            uiBtn_CreateFile.Click += UiBtn_CreateFile_Click;
            uiBtn_WriteFile.Click += UiBtn_WriteFile_Click;
            uiBtn_DeleteFile.Click += UiBtn_DeleteFile_Click;
        }

        /// <summary>
        /// 파일 삭제 버튼 클릭 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiBtn_DeleteFile_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }

        /// <summary>
        /// 파일 쓰기 버튼 클릭 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiBtn_WriteFile_Click(object sender, EventArgs e)
        {
            WriteFile();
        }

        /// <summary>
        /// 파일 생성 버튼 클릭 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiBtn_CreateFile_Click(object sender, EventArgs e)
        {
            CreateFile();
        }

        /// <summary>
        /// 파일 생성 메서드
        /// </summary>
        private void CreateFile()
        {
            string path = @"C:\test\test.txt";

            if(!File.Exists(path))
            {
                using (File.Create(path))
                {
                    MessageBox.Show("파일 생성 성공");
                }
            }
            else
            {
                MessageBox.Show("이미 파일이 존재 합니다.");
            }
        }

        /// <summary>
        /// 파일 쓰기 메서드
        /// </summary>
        private void WriteFile()
        {
            string path = @"C:\test\test.txt";

            //파일 존재 유무 확인
            if(File.Exists(path))
            {
                TxtWrite(path);
                MessageBox.Show("파일 쓰기 성공");
            }
            else
            {
                CreateFile(); //파일이 존재 하지 않으면 다시 생성
            }
        }

        /// <summary>
        /// Txt 파일 쓰기 메서드
        /// </summary>
        /// <param name="path"></param>
        private void TxtWrite(string path)
        {
            StreamWriter writer;
            writer = File.AppendText(path);
            writer.WriteLine("텍스트 파일 이어 쓰기 성공");
            writer.Close();
        }

        /// <summary>
        /// 파일 삭제 메서드
        /// </summary>
        private void DeleteFile()
        {
            string path = @"C:\test\test.txt";

            //파일 존재 유무 확인
            if (File.Exists(path))
            {
                File.Delete(path);
                MessageBox.Show("파일 삭제 성공");
            }
        }
    }
}
