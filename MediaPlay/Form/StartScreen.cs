using System;
using System.Drawing;
using System.ComponentModel;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using Global;

namespace MediaPlay
{
    class StartScreen
    {
        private GameWindow m_window;
        private int m_width;
        private int m_height;

        public StartScreen()
        { }

        public StartScreen(int width, int height)
        {
            this.m_width = width;
            this.m_height = height;
        }
        
        public StartScreen(GameWindow window)
        {
            m_window = window;
        }

        private void RegisterEvent()
        {
            //window event
            m_window.Load += M_window_Load;
            m_window.RenderFrame += M_window_RenderFrame;
            m_window.UpdateFrame += M_window_UpdateFrame;
            m_window.Closed += M_window_Closed;
            m_window.Closing += M_window_Closing;

            //Keyboard event
            m_window.KeyDown += M_window_KeyDown;
            m_window.KeyUp += M_window_KeyUp;

            //Mouse event
            m_window.MouseDown += M_window_MouseDown;
            m_window.MouseUp += M_window_MouseUp;
            m_window.MouseMove += M_window_MouseMove;


        }

        #region Window
        private void M_window_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.DarkCyan);
        }

        private void M_window_UpdateFrame(object sender, FrameEventArgs e)
        {
            
        }

        private void M_window_RenderFrame(object sender, FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Begin(PrimitiveType.Triangles);
            //Draw object here
            GL.End();
            m_window.SwapBuffers();
        }

        private void M_window_Closing(object sender, CancelEventArgs e)
        {

        }

        private void M_window_Closed(object sender, EventArgs e)
        {
            Log.LOG_DEBUG("Window closed");
        }
        #endregion //Window

        #region Mouse
        private void M_window_MouseMove(object sender, MouseMoveEventArgs e)
        {
            Log.LOG_DEBUG(string.Format("Mouse move ({0}),({1})", e.X, e.Y));
        }

        private void M_window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Log.LOG_DEBUG(string.Format("Mouse up ({0}),({1})", e.X, e.Y));
        }

        private void M_window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Log.LOG_DEBUG(string.Format("Mouse down ({0}),({1})",e.X,e.Y));
        }
        #endregion //Mouse


        #region Keyboard
        private void M_window_KeyUp(object sender, KeyboardKeyEventArgs e)
        {
            Log.LOG_DEBUG(string.Format("Key up ({0})", e.Key));
        }

        private void M_window_KeyDown(object sender, KeyboardKeyEventArgs e)
        {
            Log.LOG_DEBUG(string.Format("Key down ({0})", e.Key));
        }
        #endregion //Keyboard

        public void Initialization()
        {
            m_window = new GameWindow();
            m_window.Width = m_width;
            m_window.Height = m_height;

            m_window.Title = "Media Play";
            m_window.Icon = new Icon(_Environment.g_SolutionDir+ "/MediaPlay/Icon.ico");

            //Register events for window and peripherals
            RegisterEvent();
        }

        public void Run()
        {
            if (m_window != null)
                m_window.Run();
            else
                Log.LOG_DEBUG("m_window != null");
        }
    }
}
