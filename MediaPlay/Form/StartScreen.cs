using System;
using System.Drawing;
using System.ComponentModel;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using OpenTK.Input;
using Global;


namespace MediaPlay
{
    class StartScreen : GameWindow
    {
        Buttons b = new Buttons();
        public StartScreen()
        { }

        public StartScreen(int width, int height) : base(width, height)
        {

        }

        public StartScreen(GameWindow window) : base(window.Width, window.Height, GraphicsMode.Default, window.Title, GameWindowFlags.Default, DisplayDevice.Default)
        {

        }

        #region Window
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color.DarkCyan);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            
            GL.Begin(PrimitiveType.Triangles);
            
            GL.End();
            this.SwapBuffers();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Log.VERBOSE("Window closed");
        }
        #endregion //Window

        #region Mouse
        protected override void OnMouseMove(MouseMoveEventArgs e)
        {
            base.OnMouseMove(e);
            Log.DEBUG("Mouse move ({0}),({1})", e.X, e.Y);
        }

        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            base.OnMouseUp(e);
            Log.DEBUG("Mouse up ({0}),({1})", e.X, e.Y);
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            Log.DEBUG("Mouse down ({0}),({1})", e.X, e.Y);
        }
        #endregion //Mouse


        #region Keyboard
        protected override void OnKeyUp(KeyboardKeyEventArgs e)
        {
            base.OnKeyUp(e);
            Log.DEBUG("Key up ({0})", e.Key);
        }

        protected override void OnKeyDown(KeyboardKeyEventArgs e)
        {
            base.OnKeyDown(e);
            Log.DEBUG("Key down ({0})", e.Key);
        }
        #endregion //Keyboard

        public void Initialization()
        {
            
        }

        public new void Run()
        {
            base.Run();
        }
    }
}
