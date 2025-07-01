import { useState } from 'react';
import { motion } from "framer-motion";
import { FaEnvelope, FaPhone, FaInstagram, FaTelegram, FaLinkedin, FaGithub } from "react-icons/fa";
import emailjs from '@emailjs/browser'; // Import EmailJS

const Contact = () => {
  const [formData, setFormData] = useState({
    name: '',
    email: '',
    message: ''
  });

  const handleSubmit = (e) => {
    e.preventDefault();

    // Add EmailJS logic here
    emailjs.send(
      'service_8jrayrj', // Replace with your EmailJS service ID
      'template_3u07ms7', // Replace with your EmailJS template ID
      formData,
      'vo0eDX_ttwzaZyI2r' // Corrected public key (removed "PUBLIC_KEY_" prefix)
    )
    .then((result) => {
      console.log(result.text);
      alert("Message sent successfully!");
    }, (error) => {
      console.error(error.text);
      alert("Failed to send message. Please try again later.");
    });

    // Reset form fields
    setFormData({ name: '', email: '', message: '' });
  };

  // Animation Variants
  const containerVariants = {
    hidden: { opacity: 0 },
    visible: {
      opacity: 1,
      transition: {
        staggerChildren: 0.2, // Stagger child animations
      },
    },
  };

  const itemVariants = {
    hidden: { opacity: 0, y: 20 },
    visible: { opacity: 1, y: 0, transition: { duration: 0.5 } },
  };

  return (
    <motion.div
      initial={{ opacity: 0 }}
      animate={{ opacity: 1 }}
      exit={{ opacity: 0 }}
      className="min-h-screen flex items-center justify-center p-4 bg-gradient-to-b from-gray-100 to-white dark:from-gray-900 dark:to-gray-800"
    >
      <motion.div
        variants={containerVariants}
        initial="hidden"
        animate="visible"
        className="max-w-4xl w-full space-y-8"
      >
        {/* Title */}
        <motion.h2
          variants={itemVariants}
          className="text-4xl font-bold text-center text-transparent bg-clip-text bg-gradient-to-r from-purple-600 to-blue-600"
        >
          Get in Touch
        </motion.h2>

        {/* Social Media Links */}
        <motion.div
          variants={containerVariants}
          className="flex flex-col md:flex-row items-center justify-center gap-6 text-lg"
        >
          <motion.a
            variants={itemVariants}
            href="mailto:your-email@example.com"
            className="flex items-center gap-2 text-gray-700 dark:text-gray-300 hover:text-purple-600 transition-colors"
          >
            <FaEnvelope size={24} />
            HailegebrielSamuel@gmail.com
          </motion.a>
          <motion.a
            variants={itemVariants}
            href="tel:+1234567890"
            className="flex items-center gap-2 text-gray-700 dark:text-gray-300 hover:text-purple-600 transition-colors"
          >
            <FaPhone size={24} />
            +251945239422
          </motion.a>
          <motion.a
            variants={itemVariants}
            href="https://instagram.com/Ab_irving11"
            target="_blank"
            rel="noopener noreferrer"
            className="flex items-center gap-2 text-gray-700 dark:text-gray-300 hover:text-purple-600 transition-colors"
          >
            <FaInstagram size={24} />
            Instagram
          </motion.a>
          <motion.a
            variants={itemVariants}
            href="https://t.me/AB_KYRIE_IRVING11"
            target="_blank"
            rel="noopener noreferrer"
            className="flex items-center gap-2 text-gray-700 dark:text-gray-300 hover:text-purple-600 transition-colors"
          >
            <FaTelegram size={24} />
            Telegram
          </motion.a>
          <motion.a
            variants={itemVariants}
            href="https://linkedin.com/in/hailegebriel-samuel-13bab9303/"
            target="_blank"
            rel="noopener noreferrer"
            className="flex items-center gap-2 text-gray-700 dark:text-gray-300 hover:text-purple-600 transition-colors"
          >
            <FaLinkedin size={24} />
            LinkedIn
          </motion.a>
          <motion.a
            variants={itemVariants}
            href="https://github.com/Abirving"
            target="_blank"
            rel="noopener noreferrer"
            className="flex items-center gap-2 text-gray-700 dark:text-gray-300 hover:text-purple-600 transition-colors"
          >
            <FaGithub size={24} />
            GitHub
          </motion.a>
        </motion.div>

        {/* Contact Form */}
        <motion.form
          variants={containerVariants}
          onSubmit={handleSubmit}
          className="w-full max-w-lg mx-auto space-y-6 p-6 bg-white dark:bg-gray-800 rounded-2xl shadow-lg"
        >
          <motion.h3
            variants={itemVariants}
            className="text-2xl font-semibold text-center text-gray-800 dark:text-white"
          >
            Send a Message
          </motion.h3>

          {/* Name Field */}
          <motion.div variants={itemVariants}>
            <input
              type="text"
              placeholder="Your Name"
              className="w-full p-3 rounded-lg border dark:bg-gray-700 dark:border-gray-600 focus:outline-none focus:ring-2 focus:ring-purple-600"
              value={formData.name}
              onChange={(e) => setFormData({ ...formData, name: e.target.value })}
              required
            />
          </motion.div>

          {/* Email Field */}
          <motion.div variants={itemVariants}>
            <input
              type="email"
              placeholder="Your Email"
              className="w-full p-3 rounded-lg border dark:bg-gray-700 dark:border-gray-600 focus:outline-none focus:ring-2 focus:ring-purple-600"
              value={formData.email}
              onChange={(e) => setFormData({ ...formData, email: e.target.value })}
              required
            />
          </motion.div>

          {/* Message Field */}
          <motion.div variants={itemVariants}>
            <textarea
              placeholder="Your Message"
              rows="5"
              className="w-full p-3 rounded-lg border dark:bg-gray-700 dark:border-gray-600 focus:outline-none focus:ring-2 focus:ring-purple-600 resize-none"
              value={formData.message}
              onChange={(e) => setFormData({ ...formData, message: e.target.value })}
              required
            />
          </motion.div>

          {/* Submit Button */}
          <motion.button
            variants={itemVariants}
            whileHover={{ scale: 1.05 }}
            whileTap={{ scale: 0.95 }}
            type="submit"
            className="w-full bg-gradient-to-r from-purple-600 to-blue-600 text-white p-3 rounded-lg hover:opacity-90 transition-opacity"
          >
            Send Message
          </motion.button>
        </motion.form>
      </motion.div>
    </motion.div>
  );
};

export default Contact;