using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace ArqueCaf
{
    class Accesibilidad
    {
        private static string Frase;
        private readonly static SpeechRecognitionEngine Oidos = new SpeechRecognitionEngine();
        private readonly static SpeechSynthesizer Voz = new SpeechSynthesizer();

        public static void Inicializar()
        {
            Oidos.SetInputToDefaultAudioDevice();
            Oidos.LoadGrammar(new DictationGrammar());
            Voz.SetOutputToDefaultAudioDevice();
        }
        public static void Hablar(string texto)
        {
            Voz.SpeakAsyncCancelAll();
            Voz.SpeakAsync(texto);
        }
        public static string Escuchar()
        {            
            Voz.SpeakAsyncCancelAll();
            Escuchando();
            return Frase.ToLower();
        }

        private static void Escuchando()
        {
            try
            {
                Frase = "";
                RecognitionResult res = Oidos.Recognize();
                Frase = res.Text;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Ya se dio acceso al uso del microfono");
            }
            catch
            {
                MessageBox.Show("Error desconocido");
            }

        }
    }
}
