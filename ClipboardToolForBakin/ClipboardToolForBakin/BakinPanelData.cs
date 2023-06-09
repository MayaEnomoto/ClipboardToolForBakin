﻿using System.Text;
using System.Windows.Forms;

namespace ClipboardToolForBakin
{
    internal class BakinPanelData
    {
        public class RowData
        {
            public string Tag { get; set; }
            public string Text { get; set; }
            public string Cast1 { get; set; }
            public string ActCast1 { get; set; }
            public string Cast2 { get; set; }
            public string ActCast2 { get; set; }
            public string TalkCast { get; set; }
            public bool MirrorCast1 { get; set; }
            public bool MirrorCast2 { get; set; }
            public bool Billboard1 { get; set; }
            public bool Billboard2 { get; set; }
            public string WindowPosition { get; set; }
            public string SpeechBubble { get; set; }
            public bool UseMapLight { get; set; }
            public string Memo { get; set; }
        }

        public static void SetClipboardDataWithCustomFormat(IEnumerable<byte[]> formattedDataList)
        {
            var dataObject = new DataObject();
            foreach (var formattedData in formattedDataList)
            {
                var stream = new MemoryStream(formattedData);
                dataObject.SetData("Yukar2ScriptCommands", stream);
            }
            Clipboard.SetDataObject(dataObject, true);
        }

        public static void SetClipBoard(IEnumerable<BakinPanelData.RowData> data)
        {
            MemoryStream memoryStream = new MemoryStream();
            using (BinaryWriter writer = new BinaryWriter(memoryStream))
            {
                writer.Write((uint)data.Count());
                writer.Write(0x00000000);

                foreach (var rowData in data)
                {
                    switch (rowData.Tag)
                    {
                        case "Talk":
                            writer.Write(0x0000002b);
                            writer.Write(0x00000000);
                            writer.Write(0x02010103);
                            writer.Write(0x01030203);
                            writer.Write(0x01010101);
                            writer.Write((byte)0x01);
                            writer.Write((byte)0x00);

                            int textLength = Encoding.UTF8.GetByteCount(rowData.Text);
                            int multiple = textLength / 0x80;
                            if (multiple == 0)
                            {
                                writer.Write((byte)textLength);
                            }
                            else
                            {
                                writer.Write((byte)(textLength % 0x80 + 0x80));
                                writer.Write((byte)multiple);
                            }

                            writer.Write(Encoding.UTF8.GetBytes(rowData.Text));
                            switch (rowData.WindowPosition)
                            {
                                case "Up":
                                    writer.Write(0x00000000);
                                    break;
                                case "Center":
                                    writer.Write(0x00000001);
                                    break;
                                case "Bubble":
                                    writer.Write(0x00000100);    // Bubble&Player
                                    break;
                                case "Down":
                                default:
                                    writer.Write(0x00000002);
                                    break;
                            }
                            writer.Write(0x00000000);
                           
                            if (rowData.Cast1 == "00000000-00000000-00000000-00000000")
                            {
                                writer.Write(0x00000000);
                                writer.Write(0x00000000);
                                writer.Write(0x00000000);
                                writer.Write(0x00000000);
                                writer.Write((byte)0x00);
                            }
                            else
                            {
                                byte[] cast1Bytes = FormattedHexStringToBinary(rowData.Cast1);
                                writer.Write(cast1Bytes);
                                byte[] actCast1Bytes = Encoding.ASCII.GetBytes(rowData.ActCast1);
                                writer.Write((byte)actCast1Bytes.Length);
                                writer.Write(actCast1Bytes);
                            }
                            if (rowData.Cast2 == "00000000-00000000-00000000-00000000")
                            {
                                writer.Write(0x00000000);
                                writer.Write(0x00000000);
                                writer.Write(0x00000000);
                                writer.Write(0x00000000);
                                writer.Write((byte)0x00);
                            }
                            else
                            {
                                byte[] cast2Bytes = FormattedHexStringToBinary(rowData.Cast2);
                                writer.Write(cast2Bytes);
                                byte[] actCast2Bytes = Encoding.ASCII.GetBytes(rowData.ActCast2);
                                writer.Write((byte)actCast2Bytes.Length);
                                writer.Write(actCast2Bytes);
                            }
                            if (rowData.TalkCast == "1")
                            {
                                writer.Write(0x00000001);
                            }
                            else
                            {
                                writer.Write(0x00000000);
                            }
                            if (rowData.MirrorCast1 == true)
                            {
                                writer.Write(0x00000001);
                            }
                            else
                            {
                                writer.Write(0x00000000);
                            }
                            if (rowData.MirrorCast2 == true)
                            {
                                writer.Write(0x00000001);
                            }
                            else
                            {
                                writer.Write(0x00000000);
                            }
                            if (rowData.UseMapLight == true)
                            {
                                writer.Write(0x00000001);
                            }
                            else
                            {
                                writer.Write(0x00000000);
                            }
                            writer.Write(0x00000000);
                            writer.Write(0x00000000);
                            break;

                        case "Message":
                            writer.Write(0x0000001D);
                            writer.Write(0x00000000);
                            writer.Write(0x00010103);

                            textLength = Encoding.UTF8.GetByteCount(rowData.Text);
                            multiple = textLength / 0x80;
                            if (multiple == 0)
                            {
                                writer.Write((byte)textLength);
                            }
                            else
                            {
                                writer.Write((byte)(textLength % 0x80 + 0x80));
                                writer.Write((byte)multiple);
                            }
                            writer.Write(Encoding.UTF8.GetBytes(rowData.Text));

                            switch (rowData.WindowPosition)
                            {
                                case "Up":
                                    writer.Write(0x00000000);
                                    break;
                                case "Center":
                                    writer.Write(0x00000001);
                                    break;
                                case "Bubble":
                                    writer.Write(0x00000100);    // Bubble&Player
                                    break;
                                case "Down":
                                default:
                                    writer.Write(0x00000002);
                                    break;
                            }
                            writer.Write(0x00000000);
                            break;

                        case "Notes":
                        default:
                            writer.Write(0x0000007E);
                            writer.Write(0x00000000);
                            writer.Write((byte)0x03);
                            writer.Write((byte)0x00);
                            writer.Write((byte)Encoding.UTF8.GetByteCount(rowData.Text));
                            writer.Write(Encoding.UTF8.GetBytes(rowData.Text));
                            break;
                    }
                }
            }
            byte[] formattedData = memoryStream.ToArray();
            SetClipboardDataWithCustomFormat(new List<byte[]> { formattedData });
        }

        public static IEnumerable<BakinPanelData.RowData> GetClipBoardData()
        {
            byte[] clipboardData = GetClipboardDataWithCustomFormat();
            List<BakinPanelData.RowData> data = new List<BakinPanelData.RowData>();

            using (MemoryStream memoryStream = new MemoryStream(clipboardData))
            {
                using (BinaryReader reader = new BinaryReader(memoryStream))
                {
                    uint count = reader.ReadUInt32();
                    uint zero = reader.ReadUInt32();  // Not used

                    for (int i = 0; i < count; i++)
                    {
                        BakinPanelData.RowData rowData = new BakinPanelData.RowData();
                        uint tagId = reader.ReadUInt32();

                        switch (tagId)
                        {
                            case 0x0000002b:
                                rowData.Tag = "Talk";
                                reader.ReadUInt32();
                                reader.ReadUInt32();
                                reader.ReadUInt32();
                                reader.ReadUInt32();
                                reader.ReadByte();
                                reader.ReadByte();

                                int textLength = reader.ReadByte();
                                if (textLength > 0x7F)
                                {
                                    byte temp = reader.ReadByte();
                                    textLength = textLength + 128 * (temp - 1);
                                }
                                rowData.Text = Encoding.UTF8.GetString(reader.ReadBytes(textLength));

                                uint windowPositionId = reader.ReadUInt32();
                                rowData.WindowPosition = windowPositionId switch
                                {
                                    0x00000000 => "Up",
                                    0x00000001 => "Center",
                                    0x00000100 => "Bubble",
                                    _ => "Down"
                                };
                                reader.ReadUInt32();

                                byte[] cast1Bytes = reader.ReadBytes(16);
                                string cast1 = Encoding.ASCII.GetString(cast1Bytes).TrimEnd('\0');
                                if (cast1.Length == 0)
                                {
                                    rowData.Cast1 = "00000000-00000000-00000000-00000000";
                                    rowData.ActCast1 = "----";
                                    byte actCast1Length = reader.ReadByte();
                                }
                                else
                                {
                                    string hexData = BinaryToFormattedHexString(cast1Bytes);
                                    rowData.Cast1 = hexData;

                                    byte actCast1Length = reader.ReadByte();
                                    rowData.ActCast1 = Encoding.ASCII.GetString(reader.ReadBytes(actCast1Length));
                                }

                                byte[] cast2Bytes = reader.ReadBytes(16);
                                string cast2 = Encoding.ASCII.GetString(cast2Bytes).TrimEnd('\0');
                                if (cast2.Length == 0)
                                {
                                    rowData.Cast2 = "00000000-00000000-00000000-00000000";
                                    rowData.ActCast2 = "----";
                                    byte actCast1Length = reader.ReadByte();
                                }
                                else
                                {
                                    string hexData = BinaryToFormattedHexString(cast2Bytes);
                                    rowData.Cast2 = hexData;

                                    byte actCast2Length = reader.ReadByte();
                                    rowData.ActCast2 = Encoding.ASCII.GetString(reader.ReadBytes(actCast2Length));
                                }

                                rowData.TalkCast = reader.ReadUInt32() == 0x00000001 ? "1" : "2";
                                rowData.MirrorCast1 = reader.ReadUInt32() == 0x00000001;
                                rowData.MirrorCast2 = reader.ReadUInt32() == 0x00000001;
                                rowData.UseMapLight = reader.ReadUInt32() == 0x00000001;

                                reader.ReadUInt32();
                                reader.ReadUInt32();
                                break;

                            case 0x0000001D:
                                rowData.Tag = "Message";
                                reader.ReadUInt32();
                                reader.ReadUInt32();

                                textLength = reader.ReadByte();
                                if (textLength > 0x7F)
                                {
                                    byte temp = reader.ReadByte();
                                    textLength = textLength + 128 * (temp - 1);
                                }
                                rowData.Text = Encoding.UTF8.GetString(reader.ReadBytes(textLength));

                                windowPositionId = reader.ReadUInt32();
                                rowData.WindowPosition = windowPositionId switch
                                {
                                    0x00000000 => "Up",
                                    0x00000001 => "Center",
                                    0x00000100 => "Bubble",
                                    _ => "Down"
                                };
                                reader.ReadUInt32();
                                break;

                            case 0x0000007E:
                                rowData.Tag = "Notes";
                                reader.ReadUInt32();
                                reader.ReadByte();
                                reader.ReadByte();

                                textLength = reader.ReadByte();
                                rowData.Text = Encoding.UTF8.GetString(reader.ReadBytes(textLength));
                                break;

                            default:
                                // not for support
                                return data;
                        }

                        data.Add(rowData);
                    }
                }
            }
            return data;
        }

        private static byte[] GetClipboardDataWithCustomFormat()
        {
            if (Clipboard.ContainsData("Yukar2ScriptCommands"))
            {
                var dataObject = Clipboard.GetDataObject();
                if (dataObject != null)
                {
                    var stream = (MemoryStream)dataObject.GetData("Yukar2ScriptCommands");
                    if (stream != null)
                    {
                        return stream.ToArray();
                    }
                }
            }
            return new byte[0];
        }

        public static string BinaryToHexString(byte[] data)
        {
            return BitConverter.ToString(data).Replace("-", "");
        }

        public static byte[] HexStringToBinary(string hex)
        {
            int len = hex.Length;
            byte[] bytes = new byte[len / 2];
            for (int i = 0; i < len; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        public static string BinaryToFormattedHexString(byte[] data)
        {
            string hex = BinaryToHexString(data);
            return hex.Insert(4, "-").Insert(9, "-").Insert(14, "-").Insert(19, "-");
        }

        public static byte[] FormattedHexStringToBinary(string formattedHex)
        {
            string hex = formattedHex.Replace("-", "");
            return HexStringToBinary(hex);
        }
    }
}
